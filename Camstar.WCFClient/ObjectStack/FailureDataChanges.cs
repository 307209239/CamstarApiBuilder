// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.FailureDataChanges
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class FailureDataChanges : SubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "FailureDataChanges_FailureSeverity")]
    protected NamedObjectRef _FailureSeverity;
    [DataMember(EmitDefaultValue = false, Name = "FailureDataChanges_FailureMode")]
    protected NamedObjectRef _FailureMode;
    [DataMember(EmitDefaultValue = false, Name = "FailureDataChanges_FailureType")]
    protected NamedObjectRef _FailureType;
    [DataMember(EmitDefaultValue = false, Name = "FailureDataChanges_ListItemToChange")]
    protected new SubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "FailureDataChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "FailureDataChanges_Description")]
    protected Primitive<string> _Description;
    [DataMember(EmitDefaultValue = false, Name = "FailureDataChanges_IsFrozen")]
    protected Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is FailureDataChanges && object.Equals((object) this._FailureSeverity, (object) ((FailureDataChanges) obj)._FailureSeverity) && (object.Equals((object) this._FailureMode, (object) ((FailureDataChanges) obj)._FailureMode) && object.Equals((object) this._FailureType, (object) ((FailureDataChanges) obj)._FailureType)) && (object.Equals((object) this._ListItemToChange, (object) ((FailureDataChanges) obj)._ListItemToChange) && object.Equals((object) this._ObjectToChange, (object) ((FailureDataChanges) obj)._ObjectToChange) && (object.Equals((object) this._Description, (object) ((FailureDataChanges) obj)._Description) && object.Equals((object) this._IsFrozen, (object) ((FailureDataChanges) obj)._IsFrozen))) && base.Equals(obj);
    }

    public NamedObjectRef FailureSeverity
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailureSeverity), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (FailureSeverity));
      }
    }

    public NamedObjectRef FailureMode
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailureMode), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (FailureMode));
      }
    }

    public NamedObjectRef FailureType
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailureType), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (FailureType));
      }
    }

    public new SubentityRef ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public new SubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Primitive<string> Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Description));
      }
    }

    public Primitive<bool> IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
