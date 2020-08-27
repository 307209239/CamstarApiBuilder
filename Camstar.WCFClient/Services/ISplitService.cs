// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ISplitService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ISplitService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      Split split,
      Split_Parameters parameters,
      Split_Request request,
      out Split_Result result);

    [OperationContract]
    ResultStatus ExecuteContainerSplit(
      UserProfile userProfile,
      Split split,
      Split_Parameters parameters,
      Split_Request request,
      out Split_Result result);

    [OperationContract]
    ResultStatus ExecuteMaterialSplit(
      UserProfile userProfile,
      Split split,
      Split_Parameters parameters,
      Split_Request request,
      out Split_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      Split split,
      Split_Parameters parameters,
      Split_Request request,
      out Split_Result result);

    [OperationContract]
    ResultStatus GetContainerName(
      UserProfile userProfile,
      Split split,
      Split_Parameters parameters,
      Split_Request request,
      out Split_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      Split split,
      Split_Parameters parameters,
      Split_Request request,
      out Split_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      Split split,
      Split_Parameters parameters,
      Split_Request request,
      out Split_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      Split split,
      Split_Parameters parameters,
      Split_Request request,
      out Split_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      Split split,
      Split_LoadESigDetails_Parameters parameters,
      Split_Request request,
      out Split_Result result);

    [OperationContract]
    ResultStatus ProcessAutoNumbering(
      UserProfile userProfile,
      Split split,
      Split_Parameters parameters,
      Split_Request request,
      out Split_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      Split split,
      Split_Parameters parameters,
      Split_Request request,
      out Split_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      Split split,
      Split_Parameters parameters,
      Split_Request request,
      out Split_Result result);

    [OperationContract]
    ResultStatus SetTxnXRefsToAncestors(
      UserProfile userProfile,
      Split split,
      Split_SetTxnXRefsToAncestors_Parameters parameters,
      Split_Request request,
      out Split_Result result);

    [OperationContract]
    ResultStatus SplitContainer(
      UserProfile userProfile,
      Split split,
      Split_Parameters parameters,
      Split_Request request,
      out Split_Result result);

    [OperationContract]
    ResultStatus SplitMaterial(
      UserProfile userProfile,
      Split split,
      Split_Parameters parameters,
      Split_Request request,
      out Split_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      SplitMethod[] methods,
      Split_Request request,
      out Split_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      Split split,
      Split_Request request,
      out Split_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      Split split,
      Split_Request request,
      out Split_Result result);
  }
}
