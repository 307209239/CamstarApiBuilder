// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.INCRUpdateService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface INCRUpdateService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      NCRUpdate nCRUpdate,
      NCRUpdate_Parameters parameters,
      NCRUpdate_Request request,
      out NCRUpdate_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      NCRUpdate nCRUpdate,
      NCRUpdate_Parameters parameters,
      NCRUpdate_Request request,
      out NCRUpdate_Result result);

    [OperationContract]
    ResultStatus GetAttributes(
      UserProfile userProfile,
      NCRUpdate nCRUpdate,
      NCRUpdate_Parameters parameters,
      NCRUpdate_Request request,
      out NCRUpdate_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      NCRUpdate nCRUpdate,
      NCRUpdate_Parameters parameters,
      NCRUpdate_Request request,
      out NCRUpdate_Result result);

    [OperationContract]
    ResultStatus GetDefectHistoryDetails(
      UserProfile userProfile,
      NCRUpdate nCRUpdate,
      NCRUpdate_Parameters parameters,
      NCRUpdate_Request request,
      out NCRUpdate_Result result);

    [OperationContract]
    ResultStatus GetIssueActualsHistory(
      UserProfile userProfile,
      NCRUpdate nCRUpdate,
      NCRUpdate_Parameters parameters,
      NCRUpdate_Request request,
      out NCRUpdate_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      NCRUpdate nCRUpdate,
      NCRUpdate_Parameters parameters,
      NCRUpdate_Request request,
      out NCRUpdate_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      NCRUpdate nCRUpdate,
      NCRUpdate_Parameters parameters,
      NCRUpdate_Request request,
      out NCRUpdate_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      NCRUpdate nCRUpdate,
      NCRUpdate_LoadESigDetails_Parameters parameters,
      NCRUpdate_Request request,
      out NCRUpdate_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      NCRUpdate nCRUpdate,
      NCRUpdate_Parameters parameters,
      NCRUpdate_Request request,
      out NCRUpdate_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      NCRUpdate nCRUpdate,
      NCRUpdate_Parameters parameters,
      NCRUpdate_Request request,
      out NCRUpdate_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      NCRUpdateMethod[] methods,
      NCRUpdate_Request request,
      out NCRUpdate_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      NCRUpdate nCRUpdate,
      NCRUpdate_Request request,
      out NCRUpdate_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      NCRUpdate nCRUpdate,
      NCRUpdate_Request request,
      out NCRUpdate_Result result);
  }
}
