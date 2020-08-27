// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActivityDispositionMaint_Info
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
  public class ActivityDispositionMaint_Info : ActivityMaint_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ActivityDispositionMaint_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ActivityDispositionMaint_Info_ObjectListInquiry")]
    protected new Info _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "ActivityDispositionMaint_Info_ObjectChanges")]
    protected ActivityDispositionChanges_Info _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "ActivityDispositionMaint_Info_Template")]
    protected new Info _Template;

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new Info ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectListInquiry));
      }
    }

    public ActivityDispositionChanges_Info ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (ActivityDispositionChanges_Info) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public new Info Template
    {
      [param: In] set
      {
        this.PropertySet(nameof (Template), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Template));
      }
    }
  }
}
