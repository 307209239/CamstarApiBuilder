// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.INCRCreateService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface INCRCreateService
  {
    [OperationContract]
    ResultStatus AddHistoryCrossRefs(
      UserProfile userProfile,
      NCRCreate nCRCreate,
      NCRCreate_Parameters parameters,
      NCRCreate_Request request,
      out NCRCreate_Result result);

    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      NCRCreate nCRCreate,
      NCRCreate_Parameters parameters,
      NCRCreate_Request request,
      out NCRCreate_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      NCRCreate nCRCreate,
      NCRCreate_Parameters parameters,
      NCRCreate_Request request,
      out NCRCreate_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      NCRCreate nCRCreate,
      NCRCreate_Parameters parameters,
      NCRCreate_Request request,
      out NCRCreate_Result result);

    [OperationContract]
    ResultStatus GetIssueActualsHistory(
      UserProfile userProfile,
      NCRCreate nCRCreate,
      NCRCreate_Parameters parameters,
      NCRCreate_Request request,
      out NCRCreate_Result result);

    [OperationContract]
    ResultStatus GetNonconformanceName(
      UserProfile userProfile,
      NCRCreate nCRCreate,
      NCRCreate_Parameters parameters,
      NCRCreate_Request request,
      out NCRCreate_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      NCRCreate nCRCreate,
      NCRCreate_Parameters parameters,
      NCRCreate_Request request,
      out NCRCreate_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      NCRCreate nCRCreate,
      NCRCreate_Parameters parameters,
      NCRCreate_Request request,
      out NCRCreate_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      NCRCreate nCRCreate,
      NCRCreate_LoadESigDetails_Parameters parameters,
      NCRCreate_Request request,
      out NCRCreate_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      NCRCreate nCRCreate,
      NCRCreate_Parameters parameters,
      NCRCreate_Request request,
      out NCRCreate_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      NCRCreate nCRCreate,
      NCRCreate_Parameters parameters,
      NCRCreate_Request request,
      out NCRCreate_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      NCRCreateMethod[] methods,
      NCRCreate_Request request,
      out NCRCreate_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      NCRCreate nCRCreate,
      NCRCreate_Request request,
      out NCRCreate_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      NCRCreate nCRCreate,
      NCRCreate_Request request,
      out NCRCreate_Result result);
  }
}
