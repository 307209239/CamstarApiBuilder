// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IQualityTxnService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IQualityTxnService
  {
    [OperationContract]
    ResultStatus AddAction(
      UserProfile userProfile,
      QualityTxn qualityTxn,
      QualityTxn_Parameters parameters,
      QualityTxn_Request request,
      out QualityTxn_Result result);

    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      QualityTxn qualityTxn,
      QualityTxn_Parameters parameters,
      QualityTxn_Request request,
      out QualityTxn_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      QualityTxn qualityTxn,
      QualityTxn_Parameters parameters,
      QualityTxn_Request request,
      out QualityTxn_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      QualityTxn qualityTxn,
      QualityTxn_Parameters parameters,
      QualityTxn_Request request,
      out QualityTxn_Result result);

    [OperationContract]
    ResultStatus GetOrganization(
      UserProfile userProfile,
      QualityTxn qualityTxn,
      QualityTxn_Parameters parameters,
      QualityTxn_Request request,
      out QualityTxn_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      QualityTxn qualityTxn,
      QualityTxn_Parameters parameters,
      QualityTxn_Request request,
      out QualityTxn_Result result);

    [OperationContract]
    ResultStatus InitializeProcessObjectActions(
      UserProfile userProfile,
      QualityTxn qualityTxn,
      QualityTxn_InitializeProcessObjectActions_Parameters parameters,
      QualityTxn_Request request,
      out QualityTxn_Result result);

    [OperationContract]
    ResultStatus InitializeProcessObjectActions_User(
      UserProfile userProfile,
      QualityTxn qualityTxn,
      QualityTxn_Parameters parameters,
      QualityTxn_Request request,
      out QualityTxn_Result result);

    [OperationContract]
    ResultStatus InitializeQualityObjectActions(
      UserProfile userProfile,
      QualityTxn qualityTxn,
      QualityTxn_Parameters parameters,
      QualityTxn_Request request,
      out QualityTxn_Result result);

    [OperationContract]
    ResultStatus InitializeQualityObjectActions_User(
      UserProfile userProfile,
      QualityTxn qualityTxn,
      QualityTxn_Parameters parameters,
      QualityTxn_Request request,
      out QualityTxn_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      QualityTxn qualityTxn,
      QualityTxn_Parameters parameters,
      QualityTxn_Request request,
      out QualityTxn_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      QualityTxn qualityTxn,
      QualityTxn_Parameters parameters,
      QualityTxn_Request request,
      out QualityTxn_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      QualityTxn qualityTxn,
      QualityTxn_Parameters parameters,
      QualityTxn_Request request,
      out QualityTxn_Result result);

    [OperationContract]
    ResultStatus RemoveAction(
      UserProfile userProfile,
      QualityTxn qualityTxn,
      QualityTxn_Parameters parameters,
      QualityTxn_Request request,
      out QualityTxn_Result result);

    [OperationContract]
    ResultStatus ResolveDataCollectionDef(
      UserProfile userProfile,
      QualityTxn qualityTxn,
      QualityTxn_Parameters parameters,
      QualityTxn_Request request,
      out QualityTxn_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      QualityTxn qualityTxn,
      QualityTxn_Parameters parameters,
      QualityTxn_Request request,
      out QualityTxn_Result result);

    [OperationContract]
    ResultStatus ValidateApprovalStatus(
      UserProfile userProfile,
      QualityTxn qualityTxn,
      QualityTxn_Parameters parameters,
      QualityTxn_Request request,
      out QualityTxn_Result result);

    [OperationContract]
    ResultStatus ValidateAvailable(
      UserProfile userProfile,
      QualityTxn qualityTxn,
      QualityTxn_Parameters parameters,
      QualityTxn_Request request,
      out QualityTxn_Result result);

    [OperationContract]
    ResultStatus ValidateEmployeeRoleCombination(
      UserProfile userProfile,
      QualityTxn qualityTxn,
      QualityTxn_ValidateEmployeeRoleCombination_Parameters parameters,
      QualityTxn_Request request,
      out QualityTxn_Result result);

    [OperationContract]
    ResultStatus ValidateOwnerAssigned(
      UserProfile userProfile,
      QualityTxn qualityTxn,
      QualityTxn_Parameters parameters,
      QualityTxn_Request request,
      out QualityTxn_Result result);

    [OperationContract]
    ResultStatus ValidatePendingStatus(
      UserProfile userProfile,
      QualityTxn qualityTxn,
      QualityTxn_Parameters parameters,
      QualityTxn_Request request,
      out QualityTxn_Result result);

    [OperationContract]
    ResultStatus ValidatePermissions(
      UserProfile userProfile,
      QualityTxn qualityTxn,
      QualityTxn_Parameters parameters,
      QualityTxn_Request request,
      out QualityTxn_Result result);

    [OperationContract]
    ResultStatus ValidateQualityObjectStatus(
      UserProfile userProfile,
      QualityTxn qualityTxn,
      QualityTxn_Parameters parameters,
      QualityTxn_Request request,
      out QualityTxn_Result result);

    [OperationContract]
    ResultStatus ValidateUserAccess(
      UserProfile userProfile,
      QualityTxn qualityTxn,
      QualityTxn_Parameters parameters,
      QualityTxn_Request request,
      out QualityTxn_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      QualityTxnMethod[] methods,
      QualityTxn_Request request,
      out QualityTxn_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      QualityTxn qualityTxn,
      QualityTxn_Request request,
      out QualityTxn_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      QualityTxn qualityTxn,
      QualityTxn_Request request,
      out QualityTxn_Result result);
  }
}
