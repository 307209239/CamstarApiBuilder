// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ERPRouteMaint_Environment
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
  public class ERPRouteMaint_Environment : RevisionedObjectMaint_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ERPRouteMaint_Environment_ObjectListInquiry")]
    [Metadata("ERP Routes are the closest ERP concept to an InSite workflow.  The ERPRoute object in InSite is meant to be a miiror of the route definitions in the ERP, where the definition stored in the ERP is the \"master\" and the InSite ERPRoute is populated via LiveConnect.  The ERPRoute is used to be able to relate InSite Moves and ComponentIssues to the ERPStep where the transaction occurred.  Steps in an ERP route are usually defined at a more summarized level than is true for steps in an InSite workflow.", "ERPRouteBase", false, false, true, "RevisionedObjectRef", 1048874, false, true, false, null)]
    protected new Environment _ObjectListInquiry;
    [Metadata("ERP Routes are the closest ERP concept to an InSite workflow.  The ERPRoute object in InSite is meant to be a mirror of the route definitions in the ERP, where the definition stored in the ERP is the \"master\" and the InSite ERPRoute is populated via LiveConnect.  The ERPRoute is used to be able to relate InSite Moves and ComponentIssues to the ERPStep where the transaction occurred.  Steps in an ERP route are usually defined at a more summarized level than is true for steps in an InSite workflow.", "ERPRoute", false, false, false, "RevisionedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ERPRouteMaint_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("ERP Routes are the closest ERP concept to an InSite workflow.  The ERPRoute object in InSite is meant to be a miiror of the route definitions in the ERP, where the definition stored in the ERP is the \"master\" and the InSite ERPRoute is populated via LiveConnect.  The ERPRoute is used to be able to relate InSite Moves and ComponentIssues to the ERPStep where the transaction occurred.  Steps in an ERP route are usually defined at a more summarized level than is true for steps in an InSite workflow.", "ERPRouteChanges", false, false, false, "ERPRouteChanges", 1048873, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ERPRouteMaint_Environment_ObjectChanges")]
    protected ERPRouteChanges_Environment _ObjectChanges;
    [Metadata("ERP Routes are the closest ERP concept to an InSite workflow.  The ERPRoute object in InSite is meant to be a miiror of the route definitions in the ERP, where the definition stored in the ERP is the \"master\" and the InSite ERPRoute is populated via LiveConnect.  The ERPRoute is used to be able to relate InSite Moves and ComponentIssues to the ERPStep where the transaction occurred.  Steps in an ERP route are usually defined at a more summarized level than is true for steps in an InSite workflow.", "ERPRouteBase", false, false, false, "RevisionedObjectRef", 1049292, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ERPRouteMaint_Environment_BaseToChange")]
    protected new Environment _BaseToChange;

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

    public ERPRouteChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (ERPRouteChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }

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
  }
}
