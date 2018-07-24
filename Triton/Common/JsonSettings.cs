namespace Triton.Common
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public class JsonSettings : NotificationObject, IDisposable
    {
        [CompilerGenerated]
        private string string_0;

        public JsonSettings(string path)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(path));
            this.FilePath = path;
            this.Load();
        }

        public void Dispose()
        {
            try
            {
                this.Save();
            }
            catch
            {
            }
        }

        ~JsonSettings()
        {
            this.Dispose();
        }

        protected T GetDefaultValue<T>(Expression<Func<T>> exp)
        {
            if (exp.NodeType != ExpressionType.Lambda)
            {
                throw new ArgumentException("Value must be a lambda expression", "exp");
            }
            if (!(exp.Body is MemberExpression))
            {
                throw new ArgumentException("The body of the expression must be a memberref", "exp");
            }
            DefaultValueAttribute attribute = ((MemberExpression) exp.Body).Member.GetCustomAttributes(typeof(DefaultValueAttribute), true).FirstOrDefault<object>() as DefaultValueAttribute;
            if (attribute != null)
            {
                return (T) attribute.Value;
            }
            return default(T);
        }

        public static string GetSettingsFilePath(params string[] subPathParts)
        {
            List<string> list1 = new List<string> {
                SettingsPath
            };
            list1.AddRange(subPathParts);
            return Path.Combine(list1.ToArray());
        }

        protected void Load()
        {
            this.LoadFrom(this.FilePath);
        }

        protected void LoadFrom(string file)
        {
            foreach (PropertyInfo info in base.GetType().GetProperties())
            {
                object[] customAttributes = info.GetCustomAttributes(typeof(DefaultValueAttribute), true);
                if (customAttributes.Length != 0)
                {
                    foreach (DefaultValueAttribute attribute in customAttributes)
                    {
                        if (info.GetSetMethod() != null)
                        {
                            info.SetValue(this, attribute.Value, null);
                        }
                    }
                }
            }
            if (File.Exists(file))
            {
                string str = File.ReadAllText(file);
                try
                {
                    JsonConvert.PopulateObject(str, this);
                }
                catch (Exception)
                {
                    File.Delete(file);
                }
            }
        }

        public void Save()
        {
            if (this.FilePath != null)
            {
                this.SaveAs(this.FilePath);
            }
        }

        public void SaveAs(string file)
        {
            if (file == null)
            {
                throw new ArgumentNullException("file");
            }
            if (!File.Exists(file))
            {
                string directoryName = Path.GetDirectoryName(file);
                if ((directoryName != null) && !Directory.Exists(directoryName))
                {
                    Directory.CreateDirectory(directoryName);
                }
            }
            string contents = JsonConvert.SerializeObject(this, Formatting.Indented);
            File.WriteAllText(file, contents);
        }

        public virtual bool Validate(out List<string> errors)
        {
            errors = null;
            return true;
        }

        public static string AssemblyPath
        {
            get
            {
                return Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            }
        }

        [JsonIgnore]
        public string FilePath
        {
            [CompilerGenerated]
            get
            {
                return this.string_0;
            }
            [CompilerGenerated]
            set
            {
                this.string_0 = value;
            }
        }

        public static string SettingsPath
        {
            get
            {
                return Path.Combine(AssemblyPath, "Settings");
            }
        }
    }
}

