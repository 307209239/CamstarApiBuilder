// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Generator.DCField
// Assembly: Camstar.WCFGenerator, Version=7.8.7004.31022, Culture=neutral, PublicKeyToken=null
// MVID: 91343708-C770-4337-A57D-62D505E9E44B
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFGenerator.dll

using Camstar.WCF.Generator.ObjectModel;

namespace Camstar.WCF.Generator
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
    private CDOField _CDOField;
    private DCType _DCType;

    public string Name
    {
      get
      {
        return this._CDOField.Name;
      }
    }

    public string TypeName
    {
      get
      {
        return this._CDOField.TypeName;
      }
    }

    public bool IsSimpleType
    {
      get
      {
        return this._CDOField.IsSimpleType;
      }
    }

    public bool IsEnum
    {
      get
      {
        return this._CDOField.IsEnum;
      }
    }

    public bool IsList
    {
      get
      {
        return this._CDOField.IsList;
      }
    }

    public DCType DCType
    {
      get
      {
        return this._DCType;
      }
    }

    public string CDOTypeName
    {
      get
      {
        return this._CDOField.CDOTypeName;
      }
    }

    public string FieldTypeName
    {
      get
      {
        return this._CDOField.FieldTypeName;
      }
    }

    public string EnumFieldTypeName
    {
      get
      {
        return this._CDOField.EnumFieldTypeName;
      }
    }

    public string DefaultValue
    {
      get
      {
        return this._CDOField.DefaultValue;
      }
    }

    public string Description
    {
      get
      {
        return this._CDOField.Description;
      }
    }

    public bool IsReadOnly
    {
      get
      {
        return this._CDOField.IsReadOnly;
      }
    }

    public bool IsEncrypted
    {
      get
      {
        return this._CDOField.IsEncrypted;
      }
    }

    public bool IsRequired
    {
      get
      {
        return this._CDOField.IsRequired;
      }
    }

    public bool IsUserDefinedField
    {
      get
      {
        return this._CDOField.IsUserDefinedField;
      }
    }

    public bool HasSelVal
    {
      get
      {
        return this._CDOField.HasSelVal;
      }
    }

    public int Label
    {
      get
      {
        return this._CDOField.Label;
      }
    }

    public bool IsActual(string basefieldTypeName)
    {
      int inheritMask = this._CDOField.InheritMask;
      bool flag = basefieldTypeName != this.TypeName;
      return (inheritMask & 131072) != 0 || (inheritMask & 4096) != 0 || inheritMask == 0 && this._CDOField.InheritedID == 0 || ((inheritMask & 4) != 0 || (inheritMask & 536870912) != 0 || ((inheritMask & 1024) != 0 || (inheritMask & 2048) != 0)) || (uint) (inheritMask & 2) > 0U & flag || (uint) (inheritMask & 1073741824) > 0U;
    }

    public bool CreateOnInitialize
    {
      get
      {
        return this._CDOField.CreateOnInitialize;
      }
    }

    public DCField(CDOField cdoField, bool isEnumField)
    {
      this._CDOField = cdoField;
      if ((!this.IsSimpleType || this.IsEnum) && !isEnumField)
        this._DCType = new DCType(cdoField.TypeID, cdoField.IsSubentity, this.IsEnum);
      else
        this._DCType = (DCType) null;
    }
  }
}
