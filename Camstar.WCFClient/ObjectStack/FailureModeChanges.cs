// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.FailureModeChanges
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
  public class FailureModeChanges : UserCodeChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "FailureModeChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "FailureModeChanges_DefaultSeverity")]
    protected NamedObjectRef _DefaultSeverity;
    [DataMember(EmitDefaultValue = false, Name = "FailureModeChanges_DefaultType")]
    protected NamedObjectRef _DefaultType;
    [DataMember(EmitDefaultValue = false, Name = "FailureModeChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is FailureModeChanges && object.Equals((object) this._ObjectToChange, (object) ((FailureModeChanges) obj)._ObjectToChange) && (object.Equals((object) this._DefaultSeverity, (object) ((FailureModeChanges) obj)._DefaultSeverity) && object.Equals((object) this._DefaultType, (object) ((FailureModeChanges) obj)._DefaultType)) && object.Equals((object) this._Name, (object) ((FailureModeChanges) obj)._Name) && base.Equals(obj);
    }

    public new NamedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public NamedObjectRef DefaultSeverity
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultSeverity), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (DefaultSeverity));
      }
    }

    public NamedObjectRef DefaultType
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultType), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (DefaultType));
      }
    }

    public new Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
      }
    }
  }
}
