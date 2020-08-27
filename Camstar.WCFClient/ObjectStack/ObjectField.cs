// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ObjectField
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (SubentityField))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (ReferenceField))]
  [Serializable]
  public class ObjectField : ServiceData
  {
    [DataMember(EmitDefaultValue = false, Name = "ObjectField_FieldNameLblValue")]
    protected Primitive<string> _FieldNameLblValue;
    [DataMember(EmitDefaultValue = false, Name = "ObjectField_IsList")]
    protected Primitive<bool> _IsList;
    [DataMember(EmitDefaultValue = false, Name = "ObjectField_FieldName")]
    protected Primitive<string> _FieldName;

    public override bool Equals(object obj)
    {
      return obj is ObjectField && object.Equals((object) this._FieldNameLblValue, (object) ((ObjectField) obj)._FieldNameLblValue) && (object.Equals((object) this._IsList, (object) ((ObjectField) obj)._IsList) && object.Equals((object) this._FieldName, (object) ((ObjectField) obj)._FieldName)) && base.Equals(obj);
    }

    public Primitive<string> FieldNameLblValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (FieldNameLblValue), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (FieldNameLblValue));
      }
    }

    public Primitive<bool> IsList
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsList), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsList));
      }
    }

    public Primitive<string> FieldName
    {
      [param: In] set
      {
        this.PropertySet(nameof (FieldName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (FieldName));
      }
    }
  }
}
