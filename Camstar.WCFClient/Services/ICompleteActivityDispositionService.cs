// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ICompleteActivityDispositionService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ICompleteActivityDispositionService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      CompleteActivityDisposition completeActivityDisposition,
      CompleteActivityDisposition_Parameters parameters,
      CompleteActivityDisposition_Request request,
      out CompleteActivityDisposition_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      CompleteActivityDisposition completeActivityDisposition,
      CompleteActivityDisposition_Parameters parameters,
      CompleteActivityDisposition_Request request,
      out CompleteActivityDisposition_Result result);

    [OperationContract]
    ResultStatus GetChecklistEntries(
      UserProfile userProfile,
      CompleteActivityDisposition completeActivityDisposition,
      CompleteActivityDisposition_Parameters parameters,
      CompleteActivityDisposition_Request request,
      out CompleteActivityDisposition_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      CompleteActivityDisposition completeActivityDisposition,
      CompleteActivityDisposition_Parameters parameters,
      CompleteActivityDisposition_Request request,
      out CompleteActivityDisposition_Result result);

    [OperationContract]
    ResultStatus GetDispositionDetails(
      UserProfile userProfile,
      CompleteActivityDisposition completeActivityDisposition,
      CompleteActivityDisposition_Parameters parameters,
      CompleteActivityDisposition_Request request,
      out CompleteActivityDisposition_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      CompleteActivityDisposition completeActivityDisposition,
      CompleteActivityDisposition_Parameters parameters,
      CompleteActivityDisposition_Request request,
      out CompleteActivityDisposition_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      CompleteActivityDisposition completeActivityDisposition,
      CompleteActivityDisposition_Parameters parameters,
      CompleteActivityDisposition_Request request,
      out CompleteActivityDisposition_Result result);

    [OperationContract]
    ResultStatus LoadDataPoints(
      UserProfile userProfile,
      CompleteActivityDisposition completeActivityDisposition,
      CompleteActivityDisposition_Parameters parameters,
      CompleteActivityDisposition_Request request,
      out CompleteActivityDisposition_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      CompleteActivityDisposition completeActivityDisposition,
      CompleteActivityDisposition_Parameters parameters,
      CompleteActivityDisposition_Request request,
      out CompleteActivityDisposition_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      CompleteActivityDisposition completeActivityDisposition,
      CompleteActivityDisposition_Parameters parameters,
      CompleteActivityDisposition_Request request,
      out CompleteActivityDisposition_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      CompleteActivityDisposition completeActivityDisposition,
      CompleteActivityDisposition_Parameters parameters,
      CompleteActivityDisposition_Request request,
      out CompleteActivityDisposition_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      CompleteActivityDispositionMethod[] methods,
      CompleteActivityDisposition_Request request,
      out CompleteActivityDisposition_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      CompleteActivityDisposition completeActivityDisposition,
      CompleteActivityDisposition_Request request,
      out CompleteActivityDisposition_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      CompleteActivityDisposition completeActivityDisposition,
      CompleteActivityDisposition_Request request,
      out CompleteActivityDisposition_Result result);
  }
}
