// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NCRCauseCodeGroupMaint
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
  public class NCRCauseCodeGroupMaint : UserCodeGroupMaint
  {
    [DataMember(EmitDefaultValue = false, Name = "NCRCauseCodeGroupMaint_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "NCRCauseCodeGroupMaint_ObjectChanges")]
    protected NCRCauseCodeGroupChanges _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "NCRCauseCodeGroupMaint_ObjectListInquiry")]
    protected new NamedObjectRef[] _ObjectListInquiry;

    public override bool Equals(object obj)
    {
      return obj is NCRCauseCodeGroupMaint && object.Equals((object) this._ObjectToChange, (object) ((NCRCauseCodeGroupMaint) obj)._ObjectToChange) && (object.Equals((object) this._ObjectChanges, (object) ((NCRCauseCodeGroupMaint) obj)._ObjectChanges) && this.CompareArrays((Array) this._ObjectListInquiry, (Array) ((NCRCauseCodeGroupMaint) obj)._ObjectListInquiry)) && base.Equals(obj);
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

    public NCRCauseCodeGroupChanges ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (NCRCauseCodeGroupChanges) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public new NamedObjectRef[] ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (NamedObjectRef[]) this.PropertyGet(nameof (ObjectListInquiry));
      }
    }
  }
}
