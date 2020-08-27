// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ISignatureApprovalService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ISignatureApprovalService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      SignatureApproval signatureApproval,
      SignatureApproval_Parameters parameters,
      SignatureApproval_Request request,
      out SignatureApproval_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      SignatureApproval signatureApproval,
      SignatureApproval_Parameters parameters,
      SignatureApproval_Request request,
      out SignatureApproval_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      SignatureApproval signatureApproval,
      SignatureApproval_Parameters parameters,
      SignatureApproval_Request request,
      out SignatureApproval_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      SignatureApproval signatureApproval,
      SignatureApproval_Parameters parameters,
      SignatureApproval_Request request,
      out SignatureApproval_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      SignatureApproval signatureApproval,
      SignatureApproval_Parameters parameters,
      SignatureApproval_Request request,
      out SignatureApproval_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      SignatureApproval signatureApproval,
      SignatureApproval_LoadESigDetails_Parameters parameters,
      SignatureApproval_Request request,
      out SignatureApproval_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      SignatureApproval signatureApproval,
      SignatureApproval_Parameters parameters,
      SignatureApproval_Request request,
      out SignatureApproval_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      SignatureApproval signatureApproval,
      SignatureApproval_Parameters parameters,
      SignatureApproval_Request request,
      out SignatureApproval_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      SignatureApprovalMethod[] methods,
      SignatureApproval_Request request,
      out SignatureApproval_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      SignatureApproval signatureApproval,
      SignatureApproval_Request request,
      out SignatureApproval_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      SignatureApproval signatureApproval,
      SignatureApproval_Request request,
      out SignatureApproval_Result result);
  }
}
