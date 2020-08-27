// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IMaintenanceService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IMaintenanceService
  {
    [OperationContract]
    ResultStatus AddMassUpdateStatement(
      UserProfile userProfile,
      Maintenance maintenance,
      Maintenance_AddMassUpdateStatement_Parameters parameters,
      Maintenance_Request request,
      out Maintenance_Result result);

    [OperationContract]
    ResultStatus AssignChangePackage(
      UserProfile userProfile,
      Maintenance maintenance,
      Maintenance_Parameters parameters,
      Maintenance_Request request,
      out Maintenance_Result result);

    [OperationContract]
    ResultStatus AuthorizeSigner(
      UserProfile userProfile,
      Maintenance maintenance,
      Maintenance_AuthorizeSigner_Parameters parameters,
      Maintenance_Request request,
      out Maintenance_Result result);

    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      Maintenance maintenance,
      Maintenance_Parameters parameters,
      Maintenance_Request request,
      out Maintenance_Result result);

    [OperationContract]
    ResultStatus DeleteAllRevisions(
      UserProfile userProfile,
      Maintenance maintenance,
      Maintenance_Parameters parameters,
      Maintenance_Request request,
      out Maintenance_Result result);

    [OperationContract]
    ResultStatus Execute(
      UserProfile userProfile,
      Maintenance maintenance,
      Maintenance_Parameters parameters,
      Maintenance_Request request,
      out Maintenance_Result result);

    [OperationContract]
    ResultStatus ExecuteAdd(
      UserProfile userProfile,
      Maintenance maintenance,
      Maintenance_Parameters parameters,
      Maintenance_Request request,
      out Maintenance_Result result);

    [OperationContract]
    ResultStatus ExecuteAddRev(
      UserProfile userProfile,
      Maintenance maintenance,
      Maintenance_Parameters parameters,
      Maintenance_Request request,
      out Maintenance_Result result);

    [OperationContract]
    ResultStatus ExecuteChange(
      UserProfile userProfile,
      Maintenance maintenance,
      Maintenance_Parameters parameters,
      Maintenance_Request request,
      out Maintenance_Result result);

    [OperationContract]
    ResultStatus ExecuteDelete(
      UserProfile userProfile,
      Maintenance maintenance,
      Maintenance_Parameters parameters,
      Maintenance_Request request,
      out Maintenance_Result result);

    [OperationContract]
    ResultStatus ExecuteDeleteAll(
      UserProfile userProfile,
      Maintenance maintenance,
      Maintenance_Parameters parameters,
      Maintenance_Request request,
      out Maintenance_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      Maintenance maintenance,
      Maintenance_Parameters parameters,
      Maintenance_Request request,
      out Maintenance_Result result);

    [OperationContract]
    ResultStatus GetESigRequirements(
      UserProfile userProfile,
      Maintenance maintenance,
      Maintenance_GetESigRequirements_Parameters parameters,
      Maintenance_Request request,
      out Maintenance_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      Maintenance maintenance,
      Maintenance_Parameters parameters,
      Maintenance_Request request,
      out Maintenance_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      Maintenance maintenance,
      Maintenance_Parameters parameters,
      Maintenance_Request request,
      out Maintenance_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      Maintenance maintenance,
      Maintenance_LoadESigDetails_Parameters parameters,
      Maintenance_Request request,
      out Maintenance_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      Maintenance maintenance,
      Maintenance_Parameters parameters,
      Maintenance_Request request,
      out Maintenance_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      Maintenance maintenance,
      Maintenance_Parameters parameters,
      Maintenance_Request request,
      out Maintenance_Result result);

    [OperationContract]
    ResultStatus PostLoad(
      UserProfile userProfile,
      Maintenance maintenance,
      Maintenance_Parameters parameters,
      Maintenance_Request request,
      out Maintenance_Result result);

    [OperationContract]
    ResultStatus PostLoad_User(
      UserProfile userProfile,
      Maintenance maintenance,
      Maintenance_Parameters parameters,
      Maintenance_Request request,
      out Maintenance_Result result);

    [OperationContract]
    ResultStatus PostSave(
      UserProfile userProfile,
      Maintenance maintenance,
      Maintenance_Parameters parameters,
      Maintenance_Request request,
      out Maintenance_Result result);

    [OperationContract]
    ResultStatus PostSave_User(
      UserProfile userProfile,
      Maintenance maintenance,
      Maintenance_Parameters parameters,
      Maintenance_Request request,
      out Maintenance_Result result);

    [OperationContract]
    ResultStatus ProcessElectronicSignatures(
      UserProfile userProfile,
      Maintenance maintenance,
      Maintenance_Parameters parameters,
      Maintenance_Request request,
      out Maintenance_Result result);

    [OperationContract]
    ResultStatus RemoveChangePackages(
      UserProfile userProfile,
      Maintenance maintenance,
      Maintenance_Parameters parameters,
      Maintenance_Request request,
      out Maintenance_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      Maintenance maintenance,
      Maintenance_Parameters parameters,
      Maintenance_Request request,
      out Maintenance_Result result);

    [OperationContract]
    ResultStatus SetChangeHistory(
      UserProfile userProfile,
      Maintenance maintenance,
      Maintenance_Parameters parameters,
      Maintenance_Request request,
      out Maintenance_Result result);

    [OperationContract]
    ResultStatus SetCompletionMessage(
      UserProfile userProfile,
      Maintenance maintenance,
      Maintenance_SetCompletionMessage_Parameters parameters,
      Maintenance_Request request,
      out Maintenance_Result result);

    [OperationContract]
    ResultStatus Sync(
      UserProfile userProfile,
      Maintenance maintenance,
      Maintenance_Parameters parameters,
      Maintenance_Request request,
      out Maintenance_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      Maintenance maintenance,
      Maintenance_Parameters parameters,
      Maintenance_Request request,
      out Maintenance_Result result);

    [OperationContract]
    ResultStatus ValidateAdd(
      UserProfile userProfile,
      Maintenance maintenance,
      Maintenance_Parameters parameters,
      Maintenance_Request request,
      out Maintenance_Result result);

    [OperationContract]
    ResultStatus ValidateAddRev(
      UserProfile userProfile,
      Maintenance maintenance,
      Maintenance_Parameters parameters,
      Maintenance_Request request,
      out Maintenance_Result result);

    [OperationContract]
    ResultStatus ValidateChange(
      UserProfile userProfile,
      Maintenance maintenance,
      Maintenance_Parameters parameters,
      Maintenance_Request request,
      out Maintenance_Result result);

    [OperationContract]
    ResultStatus ValidateDelete(
      UserProfile userProfile,
      Maintenance maintenance,
      Maintenance_Parameters parameters,
      Maintenance_Request request,
      out Maintenance_Result result);

    [OperationContract]
    ResultStatus ValidateDeleteAll(
      UserProfile userProfile,
      Maintenance maintenance,
      Maintenance_Parameters parameters,
      Maintenance_Request request,
      out Maintenance_Result result);

    [OperationContract]
    ResultStatus ValidateElectronicSignatures(
      UserProfile userProfile,
      Maintenance maintenance,
      Maintenance_Parameters parameters,
      Maintenance_Request request,
      out Maintenance_Result result);

    [OperationContract]
    ResultStatus VerifyPasswordSignature(
      UserProfile userProfile,
      Maintenance maintenance,
      Maintenance_VerifyPasswordSignature_Parameters parameters,
      Maintenance_Request request,
      out Maintenance_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      MaintenanceMethod[] methods,
      Maintenance_Request request,
      out Maintenance_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      Maintenance maintenance,
      Maintenance_Request request,
      out Maintenance_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      Maintenance maintenance,
      Maintenance_Request request,
      out Maintenance_Result result);
  }
}
