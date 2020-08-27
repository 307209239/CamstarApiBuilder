// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IResourceMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IResourceMaintService
  {
    [OperationContract]
    ResultStatus CheckAssignedReqs(
      UserProfile userProfile,
      ResourceMaint resourceMaint,
      ResourceMaint_Parameters parameters,
      ResourceMaint_Request request,
      out ResourceMaint_Result result);

    [OperationContract]
    ResultStatus CreateMaintenanceStatuses(
      UserProfile userProfile,
      ResourceMaint resourceMaint,
      ResourceMaint_Parameters parameters,
      ResourceMaint_Request request,
      out ResourceMaint_Result result);

    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      ResourceMaint resourceMaint,
      ResourceMaint_Parameters parameters,
      ResourceMaint_Request request,
      out ResourceMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      ResourceMaint resourceMaint,
      ResourceMaint_Parameters parameters,
      ResourceMaint_Request request,
      out ResourceMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ResourceMaint resourceMaint,
      ResourceMaint_Parameters parameters,
      ResourceMaint_Request request,
      out ResourceMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ResourceMaint resourceMaint,
      ResourceMaint_Parameters parameters,
      ResourceMaint_Request request,
      out ResourceMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ResourceMaint resourceMaint,
      ResourceMaint_LoadESigDetails_Parameters parameters,
      ResourceMaint_Request request,
      out ResourceMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      ResourceMaint resourceMaint,
      ResourceMaint_Parameters parameters,
      ResourceMaint_Request request,
      out ResourceMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      ResourceMaint resourceMaint,
      ResourceMaint_Parameters parameters,
      ResourceMaint_Request request,
      out ResourceMaint_Result result);

    [OperationContract]
    ResultStatus RemoveMaintenanceStatuses(
      UserProfile userProfile,
      ResourceMaint resourceMaint,
      ResourceMaint_Parameters parameters,
      ResourceMaint_Request request,
      out ResourceMaint_Result result);

    [OperationContract]
    ResultStatus ResetResourceUOM(
      UserProfile userProfile,
      ResourceMaint resourceMaint,
      ResourceMaint_Parameters parameters,
      ResourceMaint_Request request,
      out ResourceMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      ResourceMaint resourceMaint,
      ResourceMaint_Parameters parameters,
      ResourceMaint_Request request,
      out ResourceMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      ResourceMaint resourceMaint,
      ResourceMaint_Parameters parameters,
      ResourceMaint_Request request,
      out ResourceMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ResourceMaintMethod[] methods,
      ResourceMaint_Request request,
      out ResourceMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ResourceMaint resourceMaint,
      ResourceMaint_Request request,
      out ResourceMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ResourceMaint resourceMaint,
      ResourceMaint_Request request,
      out ResourceMaint_Result result);
  }
}
