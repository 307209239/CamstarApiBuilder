namespace Camstar.Api.Builder
{
    internal class DCField
    {
        private const int OverrideLabelIdMask = 131072;
        private const int OverrideCreateOnInitializeMask = 4096;
        private const int NewFieldMask = 0;
        private const int OverrideRequiredMask = 4;
        private const int OverrideSerializationMask = 536870912;
        private const int OverrideAllowClientToReadMask = 1024;
        private const int OverrideAllowClientToUpdateMask = 2048;
        private const int OverrideFieldDefIdMask = 2;
        private const int OverrideOwnershipMask = 1073741824;
        private readonly CDOField _CDOField;

        public DCField(CDOField cdoField, bool isEnumField)
        {
            _CDOField = cdoField;
            if ((!IsSimpleType || IsEnum) && !isEnumField)
                DCType = new DCType(cdoField.TypeID, cdoField.IsSubentity, IsEnum);
            else
                DCType = (DCType) null;
        }

        public string Name => _CDOField.Name;

        public string TypeName => _CDOField.TypeName;

        public bool IsSimpleType => _CDOField.IsSimpleType;

        public bool IsEnum => _CDOField.IsEnum;

        public bool IsList => _CDOField.IsList;

        public DCType DCType { get; }

        public string CDOTypeName => _CDOField.CDOTypeName;

        public string FieldTypeName => _CDOField.FieldTypeName;

        public string EnumFieldTypeName => _CDOField.EnumFieldTypeName;

        public string DefaultValue => _CDOField.DefaultValue;

        public string Description => _CDOField.Description;

        public bool IsReadOnly => _CDOField.IsReadOnly;

        public bool IsEncrypted => _CDOField.IsEncrypted;

        public bool IsRequired => _CDOField.IsRequired;

        public bool IsUserDefinedField => _CDOField.IsUserDefinedField;

        public bool HasSelVal => _CDOField.HasSelVal;

        public int Label => _CDOField.Label;

        public bool CreateOnInitialize => _CDOField.CreateOnInitialize;

        public bool IsActual(string basefieldTypeName)
        {
            var inheritMask = _CDOField.InheritMask;
            var flag = basefieldTypeName != TypeName;
            return (inheritMask & 131072) != 0 || (inheritMask & 4096) != 0 ||
                   inheritMask == 0 && _CDOField.InheritedID == 0 || (inheritMask & 4) != 0 ||
                   (inheritMask & 536870912) != 0 || (inheritMask & 1024) != 0 || (inheritMask & 2048) != 0 ||
                   ((uint) (inheritMask & 2) > 0U) & flag || (uint) (inheritMask & 1073741824) > 0U;
        }
    }
}