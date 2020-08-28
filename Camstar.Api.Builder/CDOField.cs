namespace Camstar.Api.Builder
{
    internal class CDOField
    {
        private ModelDataSet.CDOFieldsRow _Row;

        private readonly string[] simpleTypeList = new string[9]
        {
            "String",
            "Integer",
            "Float",
            "Fixed",
            "String",
            "String",
            "TimeStamp",
            "Boolean",
            "Decimal"
        };

        public CDOField(ModelDataSet.CDOFieldsRow row)
        {
            _Row = row;
            IsEnum = !_Row.IsTypeNameNull() && _Row.TypeName.EndsWith("Enum");
        }

        public string Name => _Row._WCFCDOFields_Name;

        public string CDOTypeName => _Row._SelfWCFCDO_Name;

        public string CDOTypeDescription => _Row._SelfWCFCDO_Description;

        public int CDOParentTypeID => _Row.ParentID;

        public int Type => _Row.Type;

        public bool IsTypeNull => _Row.IsTypeNull();

        public string FieldTypeName
        {
            get
            {
                var str = string.Empty;
                if (!_Row.IsTypeNameNull())
                    str = _Row.TypeName;
                return str;
            }
        }

        public string TypeName
        {
            get
            {
                var str = string.Empty;
                if (!_Row.IsTypeNameNull())
                    str = _Row.TypeName;
                if (_Row.CDOFieldUsage == "Password")
                {
                    str = "EncryptedField";
                }
                else if (_Row.FieldDefName == "Password")
                {
                    str = "PasswordFieldType";
                }
                else if (!_Row.IsTypeNull())
                {
                    if (_Row.Type == 5)
                    {
                        if (_Row.Ownership == 0 && _Row.Serialization != 2 && !_Row.Is_WCFCDOFields_MaskNull())
                            str = GetTypeRef(_Row._WCFCDOFields_Mask);
                    }
                    else if (!str.EndsWith("Enum"))
                    {
                        str = GetSimpleType(_Row.Type);
                    }
                    else
                    {
                        IsEnum = true;
                    }
                }
                else
                {
                    str = typeof(string).Name;
                }

                return str;
            }
        }

        public string EnumFieldTypeName => GetSimpleType(_Row.Type);

        public bool IsSimpleType => _Row.Ownership == 0 && _Row.Serialization != 2;

        public bool IsEnum { get; private set; }

        public bool IsList => _Row.IsList;

        public int TypeID => _Row.TypeID;

        public int CDOID => _Row._SelfWCFCDO_ID;

        public bool IsReadOnly => !_Row.AllowClientToUpdate;

        public bool IsEncrypted => _Row.CDOFieldUsage == "Password";

        public bool IsUserDefinedField => _Row.IsUserDefinedField;

        public string Description => _Row._WCFCDOFields_Description;

        public bool IsRequired => _Row.Required == 2;

        public bool IsSubentity => (uint) (_Row._WCFCDOFields_Mask & 64) > 0U;

        public string DefaultValue => _Row.DefaultValue;

        public int Label => _Row.LabelID;

        public int InheritMask => !_Row.IsInheritMaskNull() ? _Row.InheritMask : 0;

        public int InheritedID => !_Row.IsInheritedIDNull() ? _Row.InheritedID : 0;

        public bool CreateOnInitialize => _Row.CreateOnInitialize;

        public bool HasSelVal => (uint) _Row.SelValMode > 0U;

        private string GetSimpleType(int typeNumber)
        {
            return simpleTypeList[typeNumber >= simpleTypeList.Length ? 0 : typeNumber];
        }

        private string GetTypeRef(int mask)
        {
            var str = "BaseObjectRef";
            if ((mask & 8) != 0)
            {
                str = "ContainerRef";
            }
            else if ((mask & 64) != 0)
            {
                str = "SubentityRef";
                if ((mask & 2) != 0)
                    str = "NamedSubentityRef";
            }
            else if ((mask & 16) != 0 || (mask & 4) != 0)
            {
                str = "RevisionedObjectRef";
            }
            else if ((mask & 2) != 0)
            {
                str = "NamedObjectRef";
            }

            return str;
        }
    }
}