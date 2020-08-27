// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IResourceMaintReqMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IResourceMaintReqMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      ResourceMaintReqMaint resourceMaintReqMaint,
      ResourceMaintReqMaint_Parameters parameters,
      ResourceMaintReqMaint_Request request,
      out ResourceMaintReqMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      ResourceMaintReqMaint resourceMaintReqMaint,
      ResourceMaintReqMaint_Parameters parameters,
      ResourceMaintReqMaint_Request request,
      out ResourceMaintReqMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ResourceMaintReqMaint resourceMaintReqMaint,
      ResourceMaintReqMaint_Parameters parameters,
      ResourceMaintReqMaint_Request request,
      out ResourceMaintReqMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ResourceMaintReqMaint resourceMaintReqMaint,
      ResourceMaintReqMaint_Parameters parameters,
      ResourceMaintReqMaint_Request request,
      out ResourceMaintReqMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ResourceMaintReqMaint resourceMaintReqMaint,
      ResourceMaintReqMaint_LoadESigDetails_Parameters parameters,
      ResourceMaintReqMaint_Request request,
      out ResourceMaintReqMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      ResourceMaintReqMaint resourceMaintReqMaint,
      ResourceMaintReqMaint_Parameters parameters,
      ResourceMaintReqMaint_Request request,
      out ResourceMaintReqMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      ResourceMaintReqMaint resourceMaintReqMaint,
      ResourceMaintReqMaint_Parameters parameters,
      ResourceMaintReqMaint_Request request,
      out ResourceMaintReqMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      ResourceMaintReqMaint resourceMaintReqMaint,
      ResourceMaintReqMaint_Parameters parameters,
      ResourceMaintReqMaint_Request request,
      out ResourceMaintReqMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      ResourceMaintReqMaint resourceMaintReqMaint,
      ResourceMaintReqMaint_Parameters parameters,
      ResourceMaintReqMaint_Request request,
      out ResourceMaintReqMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ResourceMaintReqMaintMethod[] methods,
      ResourceMaintReqMaint_Request request,
      out ResourceMaintReqMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ResourceMaintReqMaint resourceMaintReqMaint,
      ResourceMaintReqMaint_Request request,
      out ResourceMaintReqMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ResourceMaintReqMaint resourceMaintReqMaint,
      ResourceMaintReqMaint_Request request,
      out ResourceMaintReqMaint_Result result);
  }
}
