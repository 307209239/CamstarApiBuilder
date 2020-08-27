// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IShopFloorService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IShopFloorService
  {
    [OperationContract]
    ResultStatus AccumulateSummaryHistoryData(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus AddESigRequirement(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_AddESigRequirement_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus AddHistorySummary(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus AddMassUpdateStatement(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_AddMassUpdateStatement_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus AddTrainingRequirmentsToESigRequirements(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus ApplyDetails(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus ApplyParametricDetails(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus ApplyServiceDetail(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus ApplyServiceDetails(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus AuthorizeSigner(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_AuthorizeSigner_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus CheckRolePermissions(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_CheckRolePermissions_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus CreateHistoryMainline(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus DataPointConvertListToResultset(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_DataPointConvertListToResultset_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus DownloadFile(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_DownloadFile_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus EnforceDispatchRule(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus EvaluateLabelTags(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_EvaluateLabelTags_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus Execute(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus Execute_User(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus ExecuteTransactionTask(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus FinishModifyingEntity(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus GetAttributeParent(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus GetComputation(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus GetComputationParams(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus GetComputationParamsForDataPoints(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_GetComputationParamsForDataPoints_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus GetDataPointListSelectionValues(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_GetDataPointListSelectionValues_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus GetDataPointObjectGroupSelectionValues(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_GetDataPointObjectGroupSelectionValues_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus GetDataPointQuerySelectionValues(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_GetDataPointQuerySelectionValues_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus GetDataPointStaticSelectionValues(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_GetDataPointStaticSelectionValues_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus GetDefaultDispatchList(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_GetDefaultDispatchList_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus GetDispatchList(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_GetDispatchList_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus GetDispatchObject(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus GetESigRequirementFromSpec(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_GetESigRequirementFromSpec_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus GetESigRequirements(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus GetESigRequirementsFromTxnMap(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_GetESigRequirementsFromTxnMap_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus GetLabelInformation(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus GetLabelInformationFromLabelMap(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_GetLabelInformationFromLabelMap_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus GetLabelInformationFromPrinterLabel(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_GetLabelInformationFromPrinterLabel_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus GetTrainingRecord(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_GetTrainingRecord_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus GetTrainingRequirements(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus InitDispatchQueryParams(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus InitializeHistoryMainline(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_LoadESigDetails_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus ModifyEntity(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus OverrideDispatchEnforcement(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus PreExecute_User(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus PreValidate(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus PreValidate_Generic(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus PreValidate_Specific(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus PreValidate_User(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus PrintLabel(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus ProcessAfterCommit(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus ProcessAfterCommit_User(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus ProcessApplicationExtensions(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus ProcessComputationParams(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_ProcessComputationParams_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus ProcessElectronicProcedures(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus ProcessElectronicSignatures(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus ProcessLabelInformation(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus ProcessMaintenanceMgmt(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus ProcessMasterRecipe(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus ProcessNonConformances(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus RecordMainlinePostHistory(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus RecordMainlinePreHistory(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus RecordPostHistory(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus RecordPreHistory(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus RecordSummaryPostHistory(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus RecordSummaryPreHistory(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus ReplaceHistoryMainline(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus ReplaceOldHistoryMainline(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus RetrieveCalendarShift(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus Sampling_ContainerSampleData(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Sampling_ContainerSampleData_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus Sampling_EvaluateSwitchingRule(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Sampling_EvaluateSwitchingRule_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus Sampling_GetDistributionListRecipients(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Sampling_GetDistributionListRecipients_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus Sampling_LotSampleData(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Sampling_LotSampleData_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus Sampling_SendSwitchingRuleNotification(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Sampling_SendSwitchingRuleNotification_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus Sampling_SetupSampling(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus Sampling_SetupSamplingRequirement(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Sampling_SetupSamplingRequirement_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus SetHistoryMainlineTxnDates(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus StartModifyingEntity(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus UpdateCompletionMsg_PrintLabelFailure(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus UpdateCompletionMsg_PrintLabelSuccess(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus Validate(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus Validate_Generic(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus Validate_Specific(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus Validate_User(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus ValidateApplicationExtensions(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus ValidateElectronicProcedures(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus ValidateElectronicSignatures(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus ValidateESigRequirement(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_ValidateESigRequirement_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus ValidateMaintenanceMgmt(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus ValidateMaintenanceUOM(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_ValidateMaintenanceUOM_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus ValidateMasterRecipe(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus ValidateNonConformances(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus ValidateResourceMaintenance(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus ValidateTrainingRequirement(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_ValidateTrainingRequirement_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus ValidateTrainingRequirements(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus VerifyPasswordSignature(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_VerifyPasswordSignature_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ShopFloorMethod[] methods,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result);
  }
}
