// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IOperationMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IOperationMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      OperationMaint operationMaint,
      OperationMaint_Parameters parameters,
      OperationMaint_Request request,
      out OperationMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      OperationMaint operationMaint,
      OperationMaint_Parameters parameters,
      OperationMaint_Request request,
      out OperationMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      OperationMaint operationMaint,
      OperationMaint_Parameters parameters,
      OperationMaint_Request request,
      out OperationMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      OperationMaint operationMaint,
      OperationMaint_Parameters parameters,
      OperationMaint_Request request,
      out OperationMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      OperationMaint operationMaint,
      OperationMaint_LoadESigDetails_Parameters parameters,
      OperationMaint_Request request,
      out OperationMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      OperationMaint operationMaint,
      OperationMaint_Parameters parameters,
      OperationMaint_Request request,
      out OperationMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      OperationMaint operationMaint,
      OperationMaint_Parameters parameters,
      OperationMaint_Request request,
      out OperationMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      OperationMaint operationMaint,
      OperationMaint_Parameters parameters,
      OperationMaint_Request request,
      out OperationMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      OperationMaint operationMaint,
      OperationMaint_Parameters parameters,
      OperationMaint_Request request,
      out OperationMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      OperationMaintMethod[] methods,
      OperationMaint_Request request,
      out OperationMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      OperationMaint operationMaint,
      OperationMaint_Request request,
      out OperationMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      OperationMaint operationMaint,
      OperationMaint_Request request,
      out OperationMaint_Result result);
  }
}
