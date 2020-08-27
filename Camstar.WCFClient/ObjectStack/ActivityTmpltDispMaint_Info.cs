// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActivityTmpltDispMaint_Info
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
  public class ActivityTmpltDispMaint_Info : ActivityTemplateMaint_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ActivityTmpltDispMaint_Info_ObjectChanges")]
    protected ActivityTmpltDispChanges_Info _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTmpltDispMaint_Info_ObjectListInquiry")]
    protected new Info _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTmpltDispMaint_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTmpltDispMaint_Info_ProcessObjectTemplateDetails")]
    protected ActivityTemplateDisposition_Info _ProcessObjectTemplateDetails;

    public ActivityTmpltDispChanges_Info ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (ActivityTmpltDispChanges_Info) this.PropertyGet(nameof (ObjectChanges));
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

    public ActivityTemplateDisposition_Info ProcessObjectTemplateDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObjectTemplateDetails), (object) value);
      }
      get
      {
        return (ActivityTemplateDisposition_Info) this.PropertyGet(nameof (ProcessObjectTemplateDetails));
      }
    }
  }
}
