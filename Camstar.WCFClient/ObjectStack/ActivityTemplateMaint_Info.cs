// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActivityTemplateMaint_Info
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
  public class ActivityTemplateMaint_Info : ProcessObjectTemplateMaint_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplateMaint_Info_ObjectListInquiry")]
    protected new Info _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplateMaint_Info_ProcessObjectTemplateDetails")]
    protected ActivityTemplate_Info _ProcessObjectTemplateDetails;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplateMaint_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplateMaint_Info_ObjectChanges")]
    protected ActivityTemplateChanges_Info _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplateMaint_Info_ActivityType")]
    protected Info _ActivityType;

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

    public ActivityTemplate_Info ProcessObjectTemplateDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObjectTemplateDetails), (object) value);
      }
      get
      {
        return (ActivityTemplate_Info) this.PropertyGet(nameof (ProcessObjectTemplateDetails));
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

    public ActivityTemplateChanges_Info ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (ActivityTemplateChanges_Info) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public Info ActivityType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActivityType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ActivityType));
      }
    }
  }
}
