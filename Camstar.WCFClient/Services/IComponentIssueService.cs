// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IComponentIssueService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IComponentIssueService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      ComponentIssue componentIssue,
      ComponentIssue_Parameters parameters,
      ComponentIssue_Request request,
      out ComponentIssue_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      ComponentIssue componentIssue,
      ComponentIssue_Parameters parameters,
      ComponentIssue_Request request,
      out ComponentIssue_Result result);

    [OperationContract]
    ResultStatus GetAllRequirements(
      UserProfile userProfile,
      ComponentIssue componentIssue,
      ComponentIssue_Parameters parameters,
      ComponentIssue_Request request,
      out ComponentIssue_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      ComponentIssue componentIssue,
      ComponentIssue_Parameters parameters,
      ComponentIssue_Request request,
      out ComponentIssue_Result result);

    [OperationContract]
    ResultStatus GetRequirements(
      UserProfile userProfile,
      ComponentIssue componentIssue,
      ComponentIssue_Parameters parameters,
      ComponentIssue_Request request,
      out ComponentIssue_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ComponentIssue componentIssue,
      ComponentIssue_Parameters parameters,
      ComponentIssue_Request request,
      out ComponentIssue_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ComponentIssue componentIssue,
      ComponentIssue_Parameters parameters,
      ComponentIssue_Request request,
      out ComponentIssue_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ComponentIssue componentIssue,
      ComponentIssue_LoadESigDetails_Parameters parameters,
      ComponentIssue_Request request,
      out ComponentIssue_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      ComponentIssue componentIssue,
      ComponentIssue_Parameters parameters,
      ComponentIssue_Request request,
      out ComponentIssue_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      ComponentIssue componentIssue,
      ComponentIssue_Parameters parameters,
      ComponentIssue_Request request,
      out ComponentIssue_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ComponentIssueMethod[] methods,
      ComponentIssue_Request request,
      out ComponentIssue_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ComponentIssue componentIssue,
      ComponentIssue_Request request,
      out ComponentIssue_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ComponentIssue componentIssue,
      ComponentIssue_Request request,
      out ComponentIssue_Result result);
  }
}
