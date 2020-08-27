// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NCRCauseCodeChanges
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
  public class NCRCauseCodeChanges : UserCodeChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "NCRCauseCodeChanges_NCRResolutionCodeGroup")]
    protected NamedObjectRef _NCRResolutionCodeGroup;
    [DataMember(EmitDefaultValue = false, Name = "NCRCauseCodeChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "NCRCauseCodeChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is NCRCauseCodeChanges && object.Equals((object) this._NCRResolutionCodeGroup, (object) ((NCRCauseCodeChanges) obj)._NCRResolutionCodeGroup) && (object.Equals((object) this._ObjectToChange, (object) ((NCRCauseCodeChanges) obj)._ObjectToChange) && object.Equals((object) this._Name, (object) ((NCRCauseCodeChanges) obj)._Name)) && base.Equals(obj);
    }

    public NamedObjectRef NCRResolutionCodeGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRResolutionCodeGroup), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (NCRResolutionCodeGroup));
      }
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
