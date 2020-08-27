using System;
using System.Collections.Generic;
using System.Reflection;
using System.Resources;
using System.Text;

namespace Camstar.Api.Exceptions
{
   public class CamstarException:ApplicationException
    {
        private string mNamespace = string.Empty;
        private string mKey = string.Empty;
        private ResourceManager mRM;
        private Assembly mExecAssembly;
        private string[] mParameters;

        public CamstarException()
        {
            this.mKey = this.GetType().Name;
        }

        public CamstarException(string[] parameters)
        {
            this.mKey = this.GetType().Name;
            this.mParameters = parameters;
        }

        public CamstarException(string key)
        {
            this.mKey = key;
        }

        public CamstarException(string key, string parameter)
        {
            this.mKey = key;
            this.mParameters = new string[1] { parameter };
        }

        public CamstarException(string key, string[] parameters)
        {
            this.mKey = key;
            this.mParameters = parameters;
        }

        public virtual string Id
        {
            get
            {
                return ExceptionUtil.GetIdValue(this.ResourceManager, this.mKey);
            }
        }

        public virtual string Key
        {
            get
            {
                return this.mKey;
            }
        }

        public override string Message
        {
            get
            {
                return ExceptionUtil.GetMessageValue(this.ResourceManager, this.mKey, this.mParameters);
            }
        }

        protected virtual ResourceManager ResourceManager
        {
            get
            {
                if (this.mRM == null)
                    this.mRM = new ResourceManager(ExceptionUtil.GetStringResourcesBaseName(this.Namespace), this.Assembly);
                return this.mRM;
            }
        }

        protected virtual string Namespace
        {
            get
            {
                return this.mNamespace.Length > 0 ? this.mNamespace : this.GetType().Namespace;
            }
        }

        protected virtual Assembly Assembly
        {
            get
            {
                return this.mExecAssembly != (Assembly)null ? this.mExecAssembly : Assembly.GetExecutingAssembly();
            }
        }

        protected void Initialize(string callerNamespace, Assembly executingAssembly)
        {
            this.mNamespace = callerNamespace;
            this.mExecAssembly = executingAssembly;
        }
    }
}
