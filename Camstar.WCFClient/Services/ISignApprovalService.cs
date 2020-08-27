// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ISignApprovalService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ISignApprovalService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      SignApproval signApproval,
      SignApproval_Parameters parameters,
      SignApproval_Request request,
      out SignApproval_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      SignApproval signApproval,
      SignApproval_Parameters parameters,
      SignApproval_Request request,
      out SignApproval_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      SignApproval signApproval,
      SignApproval_Parameters parameters,
      SignApproval_Request request,
      out SignApproval_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      SignApproval signApproval,
      SignApproval_Parameters parameters,
      SignApproval_Request request,
      out SignApproval_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      SignApproval signApproval,
      SignApproval_Parameters parameters,
      SignApproval_Request request,
      out SignApproval_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      SignApproval signApproval,
      SignApproval_Parameters parameters,
      SignApproval_Request request,
      out SignApproval_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      SignApproval signApproval,
      SignApproval_Parameters parameters,
      SignApproval_Request request,
      out SignApproval_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      SignApproval signApproval,
      SignApproval_Parameters parameters,
      SignApproval_Request request,
      out SignApproval_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      SignApprovalMethod[] methods,
      SignApproval_Request request,
      out SignApproval_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      SignApproval signApproval,
      SignApproval_Request request,
      out SignApproval_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      SignApproval signApproval,
      SignApproval_Request request,
      out SignApproval_Result result);
  }
}
