namespace Triton.Game
{
    using Fasm;
    using GreyMagic;
    using log4net;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;

    public static class ProcessHookManager
    {
        private static AllocatedMemory allocatedMemory_0;
        private static byte[] byte_0;
        private static byte[] byte_1;
        private static byte[] byte_2;
        private static byte[] byte_3;
        private static byte[] byte_4;
        private static readonly byte[] byte_5 = new byte[0x400];
        private static readonly ILog ilog_0 = Logger.GetLoggerInstanceForType();
        private static int int_0;
        private static int int_1;
        private static int int_2;
        private static int int_3;
        private static int int_4;
        private static int int_5;
        private static int int_6;
        private static IntPtr intptr_0;
        private static IntPtr intptr_1;
        private static IntPtr intptr_2;
        private static IntPtr intptr_3;
        private static IntPtr intptr_4;
        [CompilerGenerated]
        private static StateEnum stateEnum_0;
        private static string[] string_0 = new string[] { "PatchTrack.dat" };

        public static void Disable()
        {
            if ((State == StateEnum.Enabled) && (ExternalProcessMemory_0 != null))
            {
                Reset();
                using (ExternalProcessMemory_0.TemporaryCacheState(false))
                {
                    ExternalProcessMemory_0.Patches["ProcessHookManager_GetForegroundWindow"].Remove();
                    ExternalProcessMemory_0.Patches["ProcessHookManager_GetActiveWindow"].Remove();
                    ExternalProcessMemory_0.Patches["ProcessHookManager_GetKeyState"].Remove();
                    ExternalProcessMemory_0.Patches["ProcessHookManager_GetCursorPos"].Remove();
                    ExternalProcessMemory_0.Patches["ProcessHookManager_ScreenToClient"].Remove();
                    State = StateEnum.Disabled;
                }
            }
        }

        public static void Enable()
        {
            if ((State != StateEnum.Enabled) && (ExternalProcessMemory_0 != null))
            {
                using (ExternalProcessMemory_0.TemporaryCacheState(false))
                {
                    ExternalProcessMemory_0.Patches["ProcessHookManager_GetForegroundWindow"].Apply();
                    ExternalProcessMemory_0.Patches["ProcessHookManager_GetActiveWindow"].Apply();
                    ExternalProcessMemory_0.Patches["ProcessHookManager_GetKeyState"].Apply();
                    ExternalProcessMemory_0.Patches["ProcessHookManager_GetCursorPos"].Apply();
                    ExternalProcessMemory_0.Patches["ProcessHookManager_ScreenToClient"].Apply();
                    State = StateEnum.Enabled;
                    Reset();
                }
            }
        }

        public static int GetKeyState(Keys key)
        {
            if ((key >= Keys.None) && (key <= (Keys.OemClear | Keys.LButton)))
            {
                Verify();
                using (ExternalProcessMemory_0.TemporaryCacheState(false))
                {
                    return allocatedMemory_0.Read<int>((int) (int_0 + (key * Keys.MButton)));
                }
            }
            ilog_0.ErrorFormat("[SetKeyState] The key {0} is unsupported.", key);
            return 0;
        }

        public static bool IsKeyDown(Keys key)
        {
            return ((GetKeyState(key) & 0x8000) > 0);
        }

        public static void ReadCursorPos(out int x, out int y, out int result)
        {
            Verify();
            using (ExternalProcessMemory_0.TemporaryCacheState(false))
            {
                x = allocatedMemory_0.Read<int>(int_1);
                y = allocatedMemory_0.Read<int>(int_2);
                result = allocatedMemory_0.Read<int>(int_3);
            }
        }

        public static void ReadScreenToClient(out int x, out int y, out int result)
        {
            using (ExternalProcessMemory_0.TemporaryCacheState(false))
            {
                x = allocatedMemory_0.Read<int>(int_4);
                y = allocatedMemory_0.Read<int>(int_5);
                result = allocatedMemory_0.Read<int>(int_6);
            }
        }

        public static void Reset()
        {
            ResetCursor();
            ResetKeyStates();
        }

        public static void ResetCursor()
        {
            WindowInfoWin32 windowInfo = WindowInfo;
            int x = windowInfo.Window.Left + ((windowInfo.Window.Right - windowInfo.Window.Left) / 2);
            int y = windowInfo.Window.Top + ((windowInfo.Window.Bottom - windowInfo.Window.Top) / 2);
            int num3 = (windowInfo.Client.Bottom - windowInfo.Client.Top) / 2;
            SetCursorPos(x, y, 1);
            ScreenToClient((windowInfo.Client.Right - windowInfo.Client.Left) / 2, num3, 1);
        }

        public static void ResetKeyStates()
        {
            Verify();
            using (ExternalProcessMemory_0.TemporaryCacheState(false))
            {
                allocatedMemory_0.WriteBytes(int_0, byte_5);
            }
        }

        public static void ScreenToClient(int x, int y, int result = 1)
        {
            Verify();
            using (ExternalProcessMemory_0.TemporaryCacheState(false))
            {
                allocatedMemory_0.Write<int>(int_4, x);
                allocatedMemory_0.Write<int>(int_5, y);
                allocatedMemory_0.Write<int>(int_6, result);
            }
        }

        public static void SetCursorPos(int x, int y, int result = 1)
        {
            Verify();
            using (ExternalProcessMemory_0.TemporaryCacheState(false))
            {
                allocatedMemory_0.Write<int>(int_1, x);
                allocatedMemory_0.Write<int>(int_2, y);
                allocatedMemory_0.Write<int>(int_3, result);
            }
        }

        public static void SetKeyState(Keys key, int value)
        {
            if ((key >= Keys.None) && (key <= (Keys.OemClear | Keys.LButton)))
            {
                Verify();
                using (ExternalProcessMemory_0.TemporaryCacheState(false))
                {
                    allocatedMemory_0.Write<int>((int) (int_0 + (key * Keys.MButton)), value);
                }
            }
            else
            {
                ilog_0.ErrorFormat("[SetKeyState] The key {0} is unsupported.", key);
            }
        }

        private static List<Class239> smethod_0()
        {
            List<Class239> list = new List<Class239>();
            if (File.Exists(String_0))
            {
                using (BinaryReader reader = new BinaryReader(File.OpenRead(String_0)))
                {
                    int num = reader.ReadInt32();
                    for (int i = 0; i < num; i++)
                    {
                        int num3 = reader.ReadInt32();
                        int num4 = reader.ReadInt32();
                        List<byte[]> list2 = new List<byte[]>();
                        for (int j = 0; j < num4; j++)
                        {
                            int count = reader.ReadInt32();
                            list2.Add(reader.ReadBytes(count));
                        }
                        Class239 item = new Class239 {
                            int_0 = num3,
                            list_0 = list2
                        };
                        list.Add(item);
                    }
                }
            }
            return list;
        }

        private static List<byte[]> smethod_1()
        {
            List<Class239> source = smethod_0();
            if (source.Count != 0)
            {
                Class239 class2 = source.FirstOrDefault<Class239>(Class240.<>9__35_0 ?? (Class240.<>9__35_0 = new Func<Class239, bool>(Class240.<>9.method_0)));
                if (class2 != null)
                {
                    return class2.list_0;
                }
            }
            return null;
        }

        private static void smethod_2()
        {
            List<Class239> source = smethod_0();
            if (!source.Any<Class239>((Class240.<>9__36_0 ?? (Class240.<>9__36_0 = new Func<Class239, bool>(Class240.<>9.method_1)))))
            {
                Class239 item = new Class239 {
                    int_0 = ExternalProcessMemory_0.Process.Id,
                    list_0 = new List<byte[]>()
                };
                ExternalProcessMemory memory = ExternalProcessMemory_0;
                using (TritonHs.AcquireFrame())
                {
                    item.list_0.Add(memory.Patches["ProcessHookManager_GetForegroundWindow"].OriginalBytes);
                    item.list_0.Add(memory.Patches["ProcessHookManager_GetActiveWindow"].OriginalBytes);
                    item.list_0.Add(memory.Patches["ProcessHookManager_GetKeyState"].OriginalBytes);
                    item.list_0.Add(memory.Patches["ProcessHookManager_GetCursorPos"].OriginalBytes);
                    item.list_0.Add(memory.Patches["ProcessHookManager_ScreenToClient"].OriginalBytes);
                }
                source.Add(item);
                Class239[] classArray = source.ToArray();
                int index = 0;
                while (true)
                {
                    if (index >= classArray.Length)
                    {
                        break;
                    }
                    Class239 class3 = classArray[index];
                    try
                    {
                        Process processById = Process.GetProcessById(class3.int_0);
                        try
                        {
                            if (!processById.ProcessName.ToLowerInvariant().Contains("hearthstone"))
                            {
                                source.Remove(class3);
                            }
                        }
                        catch
                        {
                            source.Remove(class3);
                        }
                    }
                    catch (ArgumentException)
                    {
                        source.Remove(class3);
                    }
                    index++;
                }
                using (FileStream stream = File.Create(String_0))
                {
                    using (BinaryWriter writer = new BinaryWriter(stream))
                    {
                        writer.Write(source.Count);
                        foreach (Class239 class4 in source)
                        {
                            writer.Write(class4.int_0);
                            writer.Write(class4.list_0.Count);
                            foreach (byte[] buffer in class4.list_0)
                            {
                                writer.Write(buffer.Length);
                                writer.Write(buffer);
                            }
                        }
                    }
                }
            }
        }

        internal static void smethod_3()
        {
            State = StateEnum.None;
            string[] strArray = string_0;
            int index = 0;
            while (true)
            {
                if (index >= strArray.Length)
                {
                    break;
                }
                string path = strArray[index];
                try
                {
                    File.Delete(path);
                }
                catch
                {
                }
                index++;
            }
            ExternalProcessMemory memory = ExternalProcessMemory_0;
            intptr_1 = memory.GetProcAddress("user32.dll", "GetActiveWindow");
            if (intptr_1 == IntPtr.Zero)
            {
                throw new Exception("The function 'GetActiveWindow' was not found.");
            }
            intptr_0 = memory.GetProcAddress("user32.dll", "GetForegroundWindow");
            if (intptr_0 == IntPtr.Zero)
            {
                throw new Exception("The function 'GetForegroundWindow' was not found.");
            }
            intptr_2 = memory.GetProcAddress("user32.dll", "GetKeyState");
            if (intptr_2 == IntPtr.Zero)
            {
                throw new Exception("The function 'GetKeyState' was not found.");
            }
            intptr_3 = memory.GetProcAddress("user32.dll", "GetCursorPos");
            if (intptr_3 == IntPtr.Zero)
            {
                throw new Exception("The function 'GetCursorPos' was not found.");
            }
            intptr_4 = memory.GetProcAddress("user32.dll", "ScreenToClient");
            if (intptr_4 == IntPtr.Zero)
            {
                throw new Exception("The function 'ScreenToClient' was not found.");
            }
            allocatedMemory_0 = memory.CreateAllocatedMemory(0x1000);
            List<byte[]> list = smethod_1();
            if (list != null)
            {
                using (TritonHs.AcquireFrame())
                {
                    ExternalProcessMemory_0.WriteBytes(intptr_0, list[0]);
                    ExternalProcessMemory_0.WriteBytes(intptr_1, list[1]);
                    ExternalProcessMemory_0.WriteBytes(intptr_2, list[2]);
                    ExternalProcessMemory_0.WriteBytes(intptr_3, list[3]);
                    ExternalProcessMemory_0.WriteBytes(intptr_4, list[4]);
                }
            }
            bool flag = false;
            try
            {
                int offsetInBytes = 0;
                IntPtr ptr = IntPtr_0;
                ManagedFasm asm = memory.Asm;
                asm.Clear();
                asm.AddLine("mov eax, " + ptr.ToString());
                asm.AddLine("retn");
                byte[] bytes = asm.Assemble();
                asm.Clear();
                allocatedMemory_0.WriteBytes(0, bytes);
                IntPtr ptr2 = allocatedMemory_0.Address + IntPtr.Zero;
                ptr2 = allocatedMemory_0.Address + IntPtr.Zero;
                int num3 = (ptr2.ToInt32() - intptr_1.ToInt32()) - 5;
                offsetInBytes = 0 + bytes.Length;
                byte_0 = new byte[5];
                byte_0[0] = 0xe9;
                byte[] buffer2 = BitConverter.GetBytes((int) ((ptr2.ToInt32() - intptr_0.ToInt32()) - 5));
                for (int i = 0; i < buffer2.Length; i++)
                {
                    byte_0[i + 1] = buffer2[i];
                }
                byte_1 = new byte[5];
                byte_1[0] = 0xe9;
                byte[] buffer3 = BitConverter.GetBytes(num3);
                for (int j = 0; j < buffer3.Length; j++)
                {
                    byte_1[j + 1] = buffer3[j];
                }
                memory.Patches.Create(intptr_0, byte_0, "ProcessHookManager_GetForegroundWindow");
                memory.Patches.Create(intptr_1, byte_1, "ProcessHookManager_GetActiveWindow");
                byte[] buffer4 = new byte[0x400];
                allocatedMemory_0.WriteBytes(offsetInBytes, buffer4);
                IntPtr ptr3 = allocatedMemory_0.Address + offsetInBytes;
                int_0 = offsetInBytes;
                offsetInBytes += 0x400;
                byte[] buffer5 = new byte[8];
                allocatedMemory_0.WriteBytes(offsetInBytes, buffer5);
                IntPtr ptr4 = allocatedMemory_0.Address + offsetInBytes;
                offsetInBytes += 4;
                IntPtr ptr5 = allocatedMemory_0.Address + offsetInBytes;
                offsetInBytes += 4;
                ManagedFasm fasm = memory.Asm;
                fasm.Clear();
                fasm.AddLine("pop eax");
                object[] args = new object[] { ptr4 };
                fasm.AddLine("mov [{0}], eax", args);
                fasm.AddLine("pop eax");
                object[] objArray2 = new object[] { ptr5 };
                fasm.AddLine("mov [{0}], eax", objArray2);
                fasm.AddLine("imul eax, 4");
                object[] objArray3 = new object[] { ptr3 };
                fasm.AddLine("add eax, {0}", objArray3);
                fasm.AddLine("mov eax, [eax]");
                object[] objArray4 = new object[] { ptr4 };
                fasm.AddLine("pushd [{0}]", objArray4);
                fasm.AddLine("retn");
                byte[] buffer6 = fasm.Assemble();
                fasm.Clear();
                allocatedMemory_0.WriteBytes(offsetInBytes, buffer6);
                ptr2 = allocatedMemory_0.Address + offsetInBytes;
                offsetInBytes += buffer6.Length;
                byte_2 = new byte[5];
                byte_2[0] = 0xe9;
                byte[] buffer7 = BitConverter.GetBytes((int) ((ptr2.ToInt32() - intptr_2.ToInt32()) - 5));
                for (int k = 0; k < buffer7.Length; k++)
                {
                    byte_2[k + 1] = buffer7[k];
                }
                memory.Patches.Create(intptr_2, byte_2, "ProcessHookManager_GetKeyState");
                byte[] buffer8 = new byte[12];
                buffer8[8] = 1;
                allocatedMemory_0.WriteBytes(offsetInBytes, buffer8);
                IntPtr ptr6 = allocatedMemory_0.Address + offsetInBytes;
                int_1 = offsetInBytes;
                offsetInBytes += 4;
                int_2 = offsetInBytes;
                offsetInBytes += 4;
                int_3 = offsetInBytes;
                offsetInBytes += 4;
                byte[] buffer9 = new byte[8];
                allocatedMemory_0.WriteBytes(offsetInBytes, buffer9);
                IntPtr ptr7 = allocatedMemory_0.Address + offsetInBytes;
                offsetInBytes += 4;
                IntPtr ptr8 = allocatedMemory_0.Address + offsetInBytes;
                offsetInBytes += 4;
                ManagedFasm fasm2 = memory.Asm;
                fasm2.Clear();
                fasm2.AddLine("pop eax");
                object[] objArray5 = new object[] { ptr7 };
                fasm2.AddLine("mov [{0}], eax", objArray5);
                fasm2.AddLine("pop eax");
                object[] objArray6 = new object[] { ptr8 };
                fasm2.AddLine("mov [{0}], eax", objArray6);
                fasm2.AddLine("push ecx");
                object[] objArray7 = new object[] { ptr6 };
                fasm2.AddLine("mov ecx, {0}", objArray7);
                fasm2.AddLine("mov ecx, [ecx]");
                fasm2.AddLine("mov [eax], ecx");
                fasm2.AddLine("add eax, 4");
                object[] objArray8 = new object[] { ptr6 };
                fasm2.AddLine("mov ecx, {0}", objArray8);
                fasm2.AddLine("add ecx, 4");
                fasm2.AddLine("mov ecx, [ecx]");
                fasm2.AddLine("mov [eax], ecx");
                object[] objArray9 = new object[] { ptr6 };
                fasm2.AddLine("mov ecx, {0}", objArray9);
                fasm2.AddLine("add ecx, 8");
                fasm2.AddLine("mov eax, [ecx]");
                fasm2.AddLine("pop ecx");
                object[] objArray10 = new object[] { ptr7 };
                fasm2.AddLine("pushd [{0}]", objArray10);
                fasm2.AddLine("retn");
                byte[] buffer10 = fasm2.Assemble();
                fasm2.Clear();
                allocatedMemory_0.WriteBytes(offsetInBytes, buffer10);
                ptr2 = allocatedMemory_0.Address + offsetInBytes;
                offsetInBytes += buffer10.Length;
                byte_3 = new byte[5];
                byte_3[0] = 0xe9;
                byte[] buffer11 = BitConverter.GetBytes((int) ((ptr2.ToInt32() - intptr_3.ToInt32()) - 5));
                for (int m = 0; m < buffer11.Length; m++)
                {
                    byte_3[m + 1] = buffer11[m];
                }
                memory.Patches.Create(intptr_3, byte_3, "ProcessHookManager_GetCursorPos");
                byte[] buffer12 = new byte[12];
                buffer12[8] = 1;
                allocatedMemory_0.WriteBytes(offsetInBytes, buffer12);
                IntPtr ptr9 = allocatedMemory_0.Address + offsetInBytes;
                int_4 = offsetInBytes;
                offsetInBytes += 4;
                int_5 = offsetInBytes;
                offsetInBytes += 4;
                int_6 = offsetInBytes;
                offsetInBytes += 4;
                byte[] buffer13 = new byte[12];
                allocatedMemory_0.WriteBytes(offsetInBytes, buffer13);
                IntPtr ptr10 = allocatedMemory_0.Address + offsetInBytes;
                offsetInBytes += 4;
                IntPtr ptr11 = allocatedMemory_0.Address + offsetInBytes;
                offsetInBytes += 4;
                IntPtr ptr12 = allocatedMemory_0.Address + offsetInBytes;
                offsetInBytes += 4;
                ManagedFasm fasm3 = memory.Asm;
                fasm3.Clear();
                fasm3.AddLine("pop eax");
                object[] objArray11 = new object[] { ptr10 };
                fasm3.AddLine("mov [{0}], eax", objArray11);
                fasm3.AddLine("pop eax");
                object[] objArray12 = new object[] { ptr11 };
                fasm3.AddLine("mov [{0}], eax", objArray12);
                fasm3.AddLine("pop eax");
                object[] objArray13 = new object[] { ptr12 };
                fasm3.AddLine("mov [{0}], eax", objArray13);
                fasm3.AddLine("push ecx");
                object[] objArray14 = new object[] { ptr9 };
                fasm3.AddLine("mov ecx, {0}", objArray14);
                fasm3.AddLine("mov ecx, [ecx]");
                fasm3.AddLine("mov [eax], ecx");
                fasm3.AddLine("add eax, 4");
                object[] objArray15 = new object[] { ptr9 };
                fasm3.AddLine("mov ecx, {0}", objArray15);
                fasm3.AddLine("add ecx, 4");
                fasm3.AddLine("mov ecx, [ecx]");
                fasm3.AddLine("mov [eax], ecx");
                object[] objArray16 = new object[] { ptr9 };
                fasm3.AddLine("mov ecx, {0}", objArray16);
                fasm3.AddLine("add ecx, 8");
                fasm3.AddLine("mov eax, [ecx]");
                fasm3.AddLine("pop ecx");
                object[] objArray17 = new object[] { ptr10 };
                fasm3.AddLine("pushd [{0}]", objArray17);
                fasm3.AddLine("retn");
                byte[] buffer14 = fasm3.Assemble();
                fasm3.Clear();
                allocatedMemory_0.WriteBytes(offsetInBytes, buffer14);
                ptr2 = allocatedMemory_0.Address + offsetInBytes;
                offsetInBytes += buffer14.Length;
                byte_4 = new byte[5];
                byte_4[0] = 0xe9;
                byte[] buffer15 = BitConverter.GetBytes((int) ((ptr2.ToInt32() - intptr_4.ToInt32()) - 5));
                for (int n = 0; n < buffer15.Length; n++)
                {
                    byte_4[n + 1] = buffer15[n];
                }
                memory.Patches.Create(intptr_4, byte_4, "ProcessHookManager_ScreenToClient");
                smethod_2();
            }
            catch (Exception)
            {
                flag = true;
                throw;
            }
            finally
            {
                if (flag && (allocatedMemory_0 != null))
                {
                    allocatedMemory_0.Dispose();
                    allocatedMemory_0 = null;
                }
            }
        }

        internal static void smethod_4()
        {
            Disable();
            if (ExternalProcessMemory_0 != null)
            {
                using (ExternalProcessMemory_0.TemporaryCacheState(false))
                {
                    ExternalProcessMemory_0.Patches.Delete("ProcessHookManager_GetForegroundWindow");
                    ExternalProcessMemory_0.Patches.Delete("ProcessHookManager_GetActiveWindow");
                    ExternalProcessMemory_0.Patches.Delete("ProcessHookManager_GetKeyState");
                    ExternalProcessMemory_0.Patches.Delete("ProcessHookManager_GetCursorPos");
                    ExternalProcessMemory_0.Patches.Delete("ProcessHookManager_ScreenToClient");
                }
            }
            if (allocatedMemory_0 != null)
            {
                allocatedMemory_0.Dispose();
                allocatedMemory_0 = null;
            }
        }

        public static bool Verify()
        {
            bool flag2;
            using (ExternalProcessMemory_0.TemporaryCacheState(false))
            {
                int num2;
                int num3;
                int num4;
                int num5;
                if (!IsEnabled)
                {
                    ilog_0.ErrorFormat("[Verify] !IsEnabled.", Array.Empty<object>());
                    return false;
                }
                byte[] buffer = ExternalProcessMemory_0.ReadBytes(intptr_1, 5);
                byte[] buffer2 = ExternalProcessMemory_0.ReadBytes(intptr_0, 5);
                byte[] buffer3 = ExternalProcessMemory_0.ReadBytes(intptr_2, 5);
                byte[] buffer4 = ExternalProcessMemory_0.ReadBytes(intptr_3, 5);
                byte[] buffer5 = ExternalProcessMemory_0.ReadBytes(intptr_4, 5);
                bool flag = false;
                for (int i = 0; i < 5; i++)
                {
                    if (byte_0[i] != buffer2[i])
                    {
                        goto Label_00AB;
                    }
                }
                goto Label_00C2;
            Label_00AB:
                flag = true;
                ilog_0.ErrorFormat("[Verify] Verification failed for function #1. This will directly affect the bot.", Array.Empty<object>());
            Label_00C2:
                num2 = 0;
                while (num2 < 5)
                {
                    if (byte_1[num2] != buffer[num2])
                    {
                        goto Label_00E4;
                    }
                    num2++;
                }
                goto Label_00FB;
            Label_00E4:
                flag = true;
                ilog_0.ErrorFormat("[Verify] Verification failed for function #2. This will directly affect the bot.", Array.Empty<object>());
            Label_00FB:
                num3 = 0;
                while (num3 < 5)
                {
                    if (byte_2[num3] != buffer3[num3])
                    {
                        goto Label_011D;
                    }
                    num3++;
                }
                goto Label_0134;
            Label_011D:
                flag = true;
                ilog_0.ErrorFormat("[Verify] Verification failed for function #4. This will directly affect the bot.", Array.Empty<object>());
            Label_0134:
                num4 = 0;
                while (num4 < 5)
                {
                    if (byte_3[num4] != buffer4[num4])
                    {
                        goto Label_0157;
                    }
                    num4++;
                }
                goto Label_016E;
            Label_0157:
                flag = true;
                ilog_0.ErrorFormat("[Verify] Verification failed for function #5. This will directly affect the bot.", Array.Empty<object>());
            Label_016E:
                num5 = 0;
                while (num5 < 5)
                {
                    if (byte_4[num5] != buffer5[num5])
                    {
                        goto Label_0191;
                    }
                    num5++;
                }
                goto Label_01A8;
            Label_0191:
                flag = true;
                ilog_0.ErrorFormat("[Verify] Verification failed for function #6. This will directly affect the bot.", Array.Empty<object>());
            Label_01A8:
                flag2 = !flag;
            }
            return flag2;
        }

        private static ExternalProcessMemory ExternalProcessMemory_0
        {
            get
            {
                return TritonHs.Memory;
            }
        }

        private static IntPtr IntPtr_0
        {
            get
            {
                return TritonHs.ClientWindowHandle;
            }
        }

        public static bool IsEnabled
        {
            get
            {
                return (State == StateEnum.Enabled);
            }
        }

        public static StateEnum State
        {
            [CompilerGenerated]
            get
            {
                return stateEnum_0;
            }
            [CompilerGenerated]
            private set
            {
                stateEnum_0 = value;
            }
        }

        private static string String_0
        {
            get
            {
                object[] args = new object[] { 1, 1, 0, 1, 1, 1, 0 };
                return string.Format("PatchTrack_v2_{0}{1}{2}{3}{4}{5}{6}", args);
            }
        }

        public static WindowInfoWin32 WindowInfo
        {
            get
            {
                WindowInfoWin32 pwi = new WindowInfoWin32 {
                    Size = (uint) MarshalCache<WindowInfoWin32>.Size
                };
                Interop.GetWindowInfo(IntPtr_0, ref pwi);
                return pwi;
            }
        }

        private class Class239 : IEquatable<ProcessHookManager.Class239>
        {
            public int int_0;
            public List<byte[]> list_0;

            public bool Equals(ProcessHookManager.Class239 other)
            {
                if (other == null)
                {
                    return false;
                }
                return ((this == other) || (this.int_0 == other.int_0));
            }

            public static bool operator ==(ProcessHookManager.Class239 left, ProcessHookManager.Class239 right)
            {
                return object.Equals(left, right);
            }

            public static bool operator !=(ProcessHookManager.Class239 left, ProcessHookManager.Class239 right)
            {
                return !object.Equals(left, right);
            }

            bool object.Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }
                if (this == obj)
                {
                    return true;
                }
                if (obj.GetType() != base.GetType())
                {
                    return false;
                }
                return this.Equals((ProcessHookManager.Class239) obj);
            }

            int object.GetHashCode()
            {
                return this.int_0;
            }

            string object.ToString()
            {
                return string.Format("Pid: {0}", this.int_0);
            }
        }

        [Serializable, CompilerGenerated]
        private sealed class Class240
        {
            public static readonly ProcessHookManager.Class240 <>9 = new ProcessHookManager.Class240();
            public static Func<ProcessHookManager.Class239, bool> <>9__35_0;
            public static Func<ProcessHookManager.Class239, bool> <>9__36_0;

            internal bool method_0(ProcessHookManager.Class239 class239_0)
            {
                return (class239_0.int_0 == ProcessHookManager.ExternalProcessMemory_0.Process.Id);
            }

            internal bool method_1(ProcessHookManager.Class239 class239_0)
            {
                return (class239_0.int_0 == ProcessHookManager.ExternalProcessMemory_0.Process.Id);
            }
        }

        public enum StateEnum
        {
            None,
            Enabled,
            Disabled
        }
    }
}

