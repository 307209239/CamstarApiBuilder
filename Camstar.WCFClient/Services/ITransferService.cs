// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ITransferService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ITransferService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      Transfer transfer,
      Transfer_Parameters parameters,
      Transfer_Request request,
      out Transfer_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      Transfer transfer,
      Transfer_Parameters parameters,
      Transfer_Request request,
      out Transfer_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      Transfer transfer,
      Transfer_Parameters parameters,
      Transfer_Request request,
      out Transfer_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      Transfer transfer,
      Transfer_Parameters parameters,
      Transfer_Request request,
      out Transfer_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      Transfer transfer,
      Transfer_Parameters parameters,
      Transfer_Request request,
      out Transfer_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      Transfer transfer,
      Transfer_LoadESigDetails_Parameters parameters,
      Transfer_Request request,
      out Transfer_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      Transfer transfer,
      Transfer_Parameters parameters,
      Transfer_Request request,
      out Transfer_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      Transfer transfer,
      Transfer_Parameters parameters,
      Transfer_Request request,
      out Transfer_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      TransferMethod[] methods,
      Transfer_Request request,
      out Transfer_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      Transfer transfer,
      Transfer_Request request,
      out Transfer_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      Transfer transfer,
      Transfer_Request request,
      out Transfer_Result result);
  }
}
