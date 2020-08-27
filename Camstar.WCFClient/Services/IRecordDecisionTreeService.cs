// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IRecordDecisionTreeService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IRecordDecisionTreeService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      RecordDecisionTree recordDecisionTree,
      RecordDecisionTree_Parameters parameters,
      RecordDecisionTree_Request request,
      out RecordDecisionTree_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      RecordDecisionTree recordDecisionTree,
      RecordDecisionTree_Parameters parameters,
      RecordDecisionTree_Request request,
      out RecordDecisionTree_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      RecordDecisionTree recordDecisionTree,
      RecordDecisionTree_Parameters parameters,
      RecordDecisionTree_Request request,
      out RecordDecisionTree_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      RecordDecisionTree recordDecisionTree,
      RecordDecisionTree_Parameters parameters,
      RecordDecisionTree_Request request,
      out RecordDecisionTree_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      RecordDecisionTree recordDecisionTree,
      RecordDecisionTree_Parameters parameters,
      RecordDecisionTree_Request request,
      out RecordDecisionTree_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      RecordDecisionTree recordDecisionTree,
      RecordDecisionTree_Parameters parameters,
      RecordDecisionTree_Request request,
      out RecordDecisionTree_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      RecordDecisionTree recordDecisionTree,
      RecordDecisionTree_Parameters parameters,
      RecordDecisionTree_Request request,
      out RecordDecisionTree_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      RecordDecisionTree recordDecisionTree,
      RecordDecisionTree_Parameters parameters,
      RecordDecisionTree_Request request,
      out RecordDecisionTree_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      RecordDecisionTreeMethod[] methods,
      RecordDecisionTree_Request request,
      out RecordDecisionTree_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      RecordDecisionTree recordDecisionTree,
      RecordDecisionTree_Request request,
      out RecordDecisionTree_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      RecordDecisionTree recordDecisionTree,
      RecordDecisionTree_Request request,
      out RecordDecisionTree_Result result);
  }
}
