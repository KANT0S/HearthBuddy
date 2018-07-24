namespace Hearthbuddy.Controls
{
    using System;
    using System.IO;
    using System.Text;
    using System.Windows.Forms;

    public class FileFolderDialog : CommonDialog
    {
        private OpenFileDialog openFileDialog_0 = new OpenFileDialog();

        public override void Reset()
        {
            this.openFileDialog_0.Reset();
        }

        protected override bool RunDialog(IntPtr hwndOwner)
        {
            return true;
        }

        public DialogResult ShowDialog()
        {
            return this.ShowDialog(null);
        }

        public DialogResult ShowDialog(IWin32Window owner)
        {
            this.openFileDialog_0.ValidateNames = false;
            this.openFileDialog_0.CheckFileExists = false;
            this.openFileDialog_0.CheckPathExists = true;
            try
            {
                if (!string.IsNullOrEmpty(this.openFileDialog_0.FileName))
                {
                    if (Directory.Exists(this.openFileDialog_0.FileName))
                    {
                        this.openFileDialog_0.InitialDirectory = this.openFileDialog_0.FileName;
                    }
                    else
                    {
                        this.openFileDialog_0.InitialDirectory = Path.GetDirectoryName(this.openFileDialog_0.FileName);
                    }
                }
            }
            catch (Exception)
            {
            }
            this.openFileDialog_0.FileName = "Folder Selection.";
            if (owner == null)
            {
                return this.openFileDialog_0.ShowDialog();
            }
            return this.openFileDialog_0.ShowDialog(owner);
        }

        public OpenFileDialog Dialog
        {
            get
            {
                return this.openFileDialog_0;
            }
            set
            {
                this.openFileDialog_0 = value;
            }
        }

        public string SelectedPath
        {
            get
            {
                try
                {
                    if (((this.openFileDialog_0.FileName != null) && (this.openFileDialog_0.FileName.EndsWith("Folder Selection.") || !File.Exists(this.openFileDialog_0.FileName))) && !Directory.Exists(this.openFileDialog_0.FileName))
                    {
                        return Path.GetDirectoryName(this.openFileDialog_0.FileName);
                    }
                    return this.openFileDialog_0.FileName;
                }
                catch (Exception)
                {
                    return this.openFileDialog_0.FileName;
                }
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.openFileDialog_0.FileName = value;
                }
            }
        }

        public string SelectedPaths
        {
            get
            {
                if ((this.openFileDialog_0.FileNames == null) || (this.openFileDialog_0.FileNames.Length <= 1))
                {
                    return null;
                }
                StringBuilder builder = new StringBuilder();
                foreach (string str in this.openFileDialog_0.FileNames)
                {
                    try
                    {
                        if (File.Exists(str))
                        {
                            builder.Append(str + ";");
                        }
                    }
                    catch
                    {
                    }
                }
                return builder.ToString();
            }
        }
    }
}

