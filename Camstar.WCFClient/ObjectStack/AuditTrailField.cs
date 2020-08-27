// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AuditTrailField
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (AuditTrailTrivialField))]
  [KnownType(typeof (AuditTrailSubentityField))]
  [Serializable]
  public class AuditTrailField : ServiceData
  {
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailField_DisplayLabel")]
    protected Primitive<string> _DisplayLabel;
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailField_DefaultLabel")]
    protected Primitive<string> _DefaultLabel;
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailField_IsList")]
    protected Primitive<bool> _IsList;
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailField_Action")]
    protected Primitive<string> _Action;
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailField_PackageName")]
    protected Primitive<string> _PackageName;
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailField_FieldName")]
    protected Primitive<string> _FieldName;

    public override bool Equals(object obj)
    {
      return obj is AuditTrailField && object.Equals((object) this._DisplayLabel, (object) ((AuditTrailField) obj)._DisplayLabel) && (object.Equals((object) this._DefaultLabel, (object) ((AuditTrailField) obj)._DefaultLabel) && object.Equals((object) this._IsList, (object) ((AuditTrailField) obj)._IsList)) && (object.Equals((object) this._Action, (object) ((AuditTrailField) obj)._Action) && object.Equals((object) this._PackageName, (object) ((AuditTrailField) obj)._PackageName) && object.Equals((object) this._FieldName, (object) ((AuditTrailField) obj)._FieldName)) && base.Equals(obj);
    }

    public Primitive<string> DisplayLabel
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayLabel), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DisplayLabel));
      }
    }

    public Primitive<string> DefaultLabel
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultLabel), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DefaultLabel));
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

    public Primitive<string> Action
    {
      [param: In] set
      {
        this.PropertySet(nameof (Action), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Action));
      }
    }

    public Primitive<string> PackageName
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (PackageName));
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
