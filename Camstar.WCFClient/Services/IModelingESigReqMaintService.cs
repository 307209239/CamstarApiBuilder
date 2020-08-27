// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IModelingESigReqMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IModelingESigReqMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      ModelingESigReqMaint modelingESigReqMaint,
      ModelingESigReqMaint_Parameters parameters,
      ModelingESigReqMaint_Request request,
      out ModelingESigReqMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      ModelingESigReqMaint modelingESigReqMaint,
      ModelingESigReqMaint_Parameters parameters,
      ModelingESigReqMaint_Request request,
      out ModelingESigReqMaint_Result result);

    [OperationContract]
    ResultStatus GetResolvedRequirements(
      UserProfile userProfile,
      ModelingESigReqMaint modelingESigReqMaint,
      ModelingESigReqMaint_Parameters parameters,
      ModelingESigReqMaint_Request request,
      out ModelingESigReqMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ModelingESigReqMaint modelingESigReqMaint,
      ModelingESigReqMaint_Parameters parameters,
      ModelingESigReqMaint_Request request,
      out ModelingESigReqMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ModelingESigReqMaint modelingESigReqMaint,
      ModelingESigReqMaint_Parameters parameters,
      ModelingESigReqMaint_Request request,
      out ModelingESigReqMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ModelingESigReqMaint modelingESigReqMaint,
      ModelingESigReqMaint_LoadESigDetails_Parameters parameters,
      ModelingESigReqMaint_Request request,
      out ModelingESigReqMaint_Result result);

    [OperationContract]
    ResultStatus LoadValues(
      UserProfile userProfile,
      ModelingESigReqMaint modelingESigReqMaint,
      ModelingESigReqMaint_Parameters parameters,
      ModelingESigReqMaint_Request request,
      out ModelingESigReqMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      ModelingESigReqMaint modelingESigReqMaint,
      ModelingESigReqMaint_Parameters parameters,
      ModelingESigReqMaint_Request request,
      out ModelingESigReqMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      ModelingESigReqMaint modelingESigReqMaint,
      ModelingESigReqMaint_Parameters parameters,
      ModelingESigReqMaint_Request request,
      out ModelingESigReqMaint_Result result);

    [OperationContract]
    ResultStatus Process(
      UserProfile userProfile,
      ModelingESigReqMaint modelingESigReqMaint,
      ModelingESigReqMaint_Parameters parameters,
      ModelingESigReqMaint_Request request,
      out ModelingESigReqMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      ModelingESigReqMaint modelingESigReqMaint,
      ModelingESigReqMaint_Parameters parameters,
      ModelingESigReqMaint_Request request,
      out ModelingESigReqMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      ModelingESigReqMaint modelingESigReqMaint,
      ModelingESigReqMaint_Parameters parameters,
      ModelingESigReqMaint_Request request,
      out ModelingESigReqMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ModelingESigReqMaintMethod[] methods,
      ModelingESigReqMaint_Request request,
      out ModelingESigReqMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ModelingESigReqMaint modelingESigReqMaint,
      ModelingESigReqMaint_Request request,
      out ModelingESigReqMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ModelingESigReqMaint modelingESigReqMaint,
      ModelingESigReqMaint_Request request,
      out ModelingESigReqMaint_Result result);
  }
}
