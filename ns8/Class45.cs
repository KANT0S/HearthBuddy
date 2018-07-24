namespace ns8
{
    using System;
    using System.Runtime.CompilerServices;
    using System.ServiceModel;

    internal static class Class45
    {
        public static void smethod_0(Action<Class40> action_0)
        {
            Class46 class1 = new Class46 {
                action_0 = action_0
            };
            smethod_2<object>(new Func<Class40, object>(class1.method_0));
        }

        public static object smethod_1(Func<Class40, object> func_0)
        {
            return smethod_2<object>(func_0);
        }

        public static T smethod_2<T>(Func<Class40, T> func_0)
        {
            T local;
            try
            {
                Class40 arg = new Class40();
                bool flag = false;
                try
                {
                    arg.method_2();
                    flag = true;
                    local = func_0(arg);
                }
                catch (EndpointNotFoundException)
                {
                    arg.method_1();
                    local = smethod_2<T>(func_0);
                }
                catch (CommunicationException)
                {
                    arg.method_1();
                    local = smethod_2<T>(func_0);
                }
                catch (TimeoutException)
                {
                    arg.method_1();
                    local = smethod_2<T>(func_0);
                }
                catch (Exception)
                {
                    arg.method_1();
                    throw;
                }
                finally
                {
                    if (!flag && (arg.CommunicationState_0 != CommunicationState.Closed))
                    {
                        arg.method_1();
                    }
                }
            }
            catch
            {
                local = default(T);
            }
            return local;
        }

        [CompilerGenerated]
        private sealed class Class46
        {
            public Action<Class40> action_0;

            internal object method_0(Class40 class40_0)
            {
                this.action_0(class40_0);
                return null;
            }
        }
    }
}

