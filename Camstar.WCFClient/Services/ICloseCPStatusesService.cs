// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ICloseCPStatusesService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ICloseCPStatusesService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      CloseCPStatuses closeCPStatuses,
      CloseCPStatuses_Parameters parameters,
      CloseCPStatuses_Request request,
      out CloseCPStatuses_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      CloseCPStatuses closeCPStatuses,
      CloseCPStatuses_Parameters parameters,
      CloseCPStatuses_Request request,
      out CloseCPStatuses_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      CloseCPStatuses closeCPStatuses,
      CloseCPStatuses_Parameters parameters,
      CloseCPStatuses_Request request,
      out CloseCPStatuses_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      CloseCPStatuses closeCPStatuses,
      CloseCPStatuses_Parameters parameters,
      CloseCPStatuses_Request request,
      out CloseCPStatuses_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      CloseCPStatuses closeCPStatuses,
      CloseCPStatuses_Parameters parameters,
      CloseCPStatuses_Request request,
      out CloseCPStatuses_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      CloseCPStatuses closeCPStatuses,
      CloseCPStatuses_LoadESigDetails_Parameters parameters,
      CloseCPStatuses_Request request,
      out CloseCPStatuses_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      CloseCPStatuses closeCPStatuses,
      CloseCPStatuses_Parameters parameters,
      CloseCPStatuses_Request request,
      out CloseCPStatuses_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      CloseCPStatuses closeCPStatuses,
      CloseCPStatuses_Parameters parameters,
      CloseCPStatuses_Request request,
      out CloseCPStatuses_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      CloseCPStatusesMethod[] methods,
      CloseCPStatuses_Request request,
      out CloseCPStatuses_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      CloseCPStatuses closeCPStatuses,
      CloseCPStatuses_Request request,
      out CloseCPStatuses_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      CloseCPStatuses closeCPStatuses,
      CloseCPStatuses_Request request,
      out CloseCPStatuses_Result result);
  }
}
