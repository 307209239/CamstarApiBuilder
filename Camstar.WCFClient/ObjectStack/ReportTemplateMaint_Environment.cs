// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ReportTemplateMaint_Environment
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
  public class ReportTemplateMaint_Environment : DocumentMaint_Environment
  {
    [Metadata("Report Template object to intelligence report templates", "ReportTemplateBase", false, false, false, "RevisionedObjectRef", 1049292, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ReportTemplateMaint_Environment_BaseToChange")]
    protected new Environment _BaseToChange;
    [Metadata("Report Template object to intelligence report templates", "ReportTemplateBase", false, false, true, "RevisionedObjectRef", 1048874, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ReportTemplateMaint_Environment_ObjectListInquiry")]
    protected new Environment _ObjectListInquiry;
    [Metadata("Report Template object to intelligence report templates", "ReportTemplateChanges", false, false, false, "ReportTemplateChanges", 1048873, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ReportTemplateMaint_Environment_ObjectChanges")]
    protected ReportTemplateChanges_Environment _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "ReportTemplateMaint_Environment_ObjectToChange")]
    [Metadata("Report Template object to intelligence report templates", "ReportTemplate", false, false, false, "RevisionedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;

    public new Environment BaseToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (BaseToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (BaseToChange));
      }
    }

    public new Environment ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectListInquiry));
      }
    }

    public ReportTemplateChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (ReportTemplateChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }
  }
}
