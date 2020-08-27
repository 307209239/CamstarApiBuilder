// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IComponentRemoveService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IComponentRemoveService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      ComponentRemove componentRemove,
      ComponentRemove_Parameters parameters,
      ComponentRemove_Request request,
      out ComponentRemove_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      ComponentRemove componentRemove,
      ComponentRemove_Parameters parameters,
      ComponentRemove_Request request,
      out ComponentRemove_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      ComponentRemove componentRemove,
      ComponentRemove_Parameters parameters,
      ComponentRemove_Request request,
      out ComponentRemove_Result result);

    [OperationContract]
    ResultStatus GetIssueActualsHistory(
      UserProfile userProfile,
      ComponentRemove componentRemove,
      ComponentRemove_Parameters parameters,
      ComponentRemove_Request request,
      out ComponentRemove_Result result);

    [OperationContract]
    ResultStatus GetRemovalCandidates(
      UserProfile userProfile,
      ComponentRemove componentRemove,
      ComponentRemove_Parameters parameters,
      ComponentRemove_Request request,
      out ComponentRemove_Result result);

    [OperationContract]
    ResultStatus GetRemovalHistoryDetails(
      UserProfile userProfile,
      ComponentRemove componentRemove,
      ComponentRemove_Parameters parameters,
      ComponentRemove_Request request,
      out ComponentRemove_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ComponentRemove componentRemove,
      ComponentRemove_Parameters parameters,
      ComponentRemove_Request request,
      out ComponentRemove_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ComponentRemove componentRemove,
      ComponentRemove_Parameters parameters,
      ComponentRemove_Request request,
      out ComponentRemove_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ComponentRemove componentRemove,
      ComponentRemove_LoadESigDetails_Parameters parameters,
      ComponentRemove_Request request,
      out ComponentRemove_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      ComponentRemove componentRemove,
      ComponentRemove_Parameters parameters,
      ComponentRemove_Request request,
      out ComponentRemove_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      ComponentRemove componentRemove,
      ComponentRemove_Parameters parameters,
      ComponentRemove_Request request,
      out ComponentRemove_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ComponentRemoveMethod[] methods,
      ComponentRemove_Request request,
      out ComponentRemove_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ComponentRemove componentRemove,
      ComponentRemove_Request request,
      out ComponentRemove_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ComponentRemove componentRemove,
      ComponentRemove_Request request,
      out ComponentRemove_Result result);
  }
}
