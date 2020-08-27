// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Generator.ObjectModel.CDOField
// Assembly: Camstar.WCFGenerator, Version=7.8.7004.31022, Culture=neutral, PublicKeyToken=null
// MVID: 91343708-C770-4337-A57D-62D505E9E44B
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFGenerator.dll

namespace Camstar.WCF.Generator.ObjectModel
{
  internal class CDOField
  {
    private string[] simpleTypeList = new string[9]
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
    private bool _IsEnum;
    private ModelDataSet.CDOFieldsRow _Row;

    public CDOField(ModelDataSet.CDOFieldsRow row)
    {
      this._Row = row;
      this._IsEnum = !this._Row.IsTypeNameNull() && this._Row.TypeName.EndsWith("Enum");
    }

    public string Name
    {
      get
      {
        return this._Row._WCFCDOFields_Name;
      }
    }

    public string CDOTypeName
    {
      get
      {
        return this._Row._SelfWCFCDO_Name;
      }
    }

    public string CDOTypeDescription
    {
      get
      {
        return this._Row._SelfWCFCDO_Description;
      }
    }

    public int CDOParentTypeID
    {
      get
      {
        return this._Row.ParentID;
      }
    }

    public int Type
    {
      get
      {
        return this._Row.Type;
      }
    }

    public bool IsTypeNull
    {
      get
      {
        return this._Row.IsTypeNull();
      }
    }

    public string FieldTypeName
    {
      get
      {
        string str = string.Empty;
        if (!this._Row.IsTypeNameNull())
          str = this._Row.TypeName;
        return str;
      }
    }

    public string TypeName
    {
      get
      {
        string str = string.Empty;
        if (!this._Row.IsTypeNameNull())
          str = this._Row.TypeName;
        if (this._Row.CDOFieldUsage == "Password")
          str = "EncryptedField";
        else if (this._Row.FieldDefName == "Password")
          str = "PasswordFieldType";
        else if (!this._Row.IsTypeNull())
        {
          if (this._Row.Type == 5)
          {
            if (this._Row.Ownership == 0 && this._Row.Serialization != 2 && !this._Row.Is_WCFCDOFields_MaskNull())
              str = this.GetTypeRef(this._Row._WCFCDOFields_Mask);
          }
          else if (!str.EndsWith("Enum"))
            str = this.GetSimpleType(this._Row.Type);
          else
            this._IsEnum = true;
        }
        else
          str = typeof (string).Name;
        return str;
      }
    }

    public string EnumFieldTypeName
    {
      get
      {
        return this.GetSimpleType(this._Row.Type);
      }
    }

    public bool IsSimpleType
    {
      get
      {
        return this._Row.Ownership == 0 && this._Row.Serialization != 2;
      }
    }

    public bool IsEnum
    {
      get
      {
        return this._IsEnum;
      }
    }

    public bool IsList
    {
      get
      {
        return this._Row.IsList;
      }
    }

    public int TypeID
    {
      get
      {
        return this._Row.TypeID;
      }
    }

    public int CDOID
    {
      get
      {
        return this._Row._SelfWCFCDO_ID;
      }
    }

    public bool IsReadOnly
    {
      get
      {
        return !this._Row.AllowClientToUpdate;
      }
    }

    public bool IsEncrypted
    {
      get
      {
        return this._Row.CDOFieldUsage == "Password";
      }
    }

    public bool IsUserDefinedField
    {
      get
      {
        return this._Row.IsUserDefinedField;
      }
    }

    public string Description
    {
      get
      {
        return this._Row._WCFCDOFields_Description;
      }
    }

    public bool IsRequired
    {
      get
      {
        return this._Row.Required == 2;
      }
    }

    public bool IsSubentity
    {
      get
      {
        return (uint) (this._Row._WCFCDOFields_Mask & 64) > 0U;
      }
    }

    public string DefaultValue
    {
      get
      {
        return this._Row.DefaultValue;
      }
    }

    public int Label
    {
      get
      {
        return this._Row.LabelID;
      }
    }

    public int InheritMask
    {
      get
      {
        return !this._Row.IsInheritMaskNull() ? this._Row.InheritMask : 0;
      }
    }

    public int InheritedID
    {
      get
      {
        return !this._Row.IsInheritedIDNull() ? this._Row.InheritedID : 0;
      }
    }

    public bool CreateOnInitialize
    {
      get
      {
        return this._Row.CreateOnInitialize;
      }
    }

    public bool HasSelVal
    {
      get
      {
        return (uint) this._Row.SelValMode > 0U;
      }
    }

    private string GetSimpleType(int typeNumber)
    {
      return this.simpleTypeList[typeNumber >= this.simpleTypeList.Length ? 0 : typeNumber];
    }

    private string GetTypeRef(int mask)
    {
      string str = "BaseObjectRef";
      if ((mask & 8) != 0)
        str = "ContainerRef";
      else if ((mask & 64) != 0)
      {
        str = "SubentityRef";
        if ((mask & 2) != 0)
          str = "NamedSubentityRef";
      }
      else if ((mask & 16) != 0 || (mask & 4) != 0)
        str = "RevisionedObjectRef";
      else if ((mask & 2) != 0)
        str = "NamedObjectRef";
      return str;
    }
  }
}
