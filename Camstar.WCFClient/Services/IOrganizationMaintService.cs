// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IOrganizationMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IOrganizationMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      OrganizationMaint organizationMaint,
      OrganizationMaint_Parameters parameters,
      OrganizationMaint_Request request,
      out OrganizationMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      OrganizationMaint organizationMaint,
      OrganizationMaint_Parameters parameters,
      OrganizationMaint_Request request,
      out OrganizationMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      OrganizationMaint organizationMaint,
      OrganizationMaint_Parameters parameters,
      OrganizationMaint_Request request,
      out OrganizationMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      OrganizationMaint organizationMaint,
      OrganizationMaint_Parameters parameters,
      OrganizationMaint_Request request,
      out OrganizationMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      OrganizationMaint organizationMaint,
      OrganizationMaint_LoadESigDetails_Parameters parameters,
      OrganizationMaint_Request request,
      out OrganizationMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      OrganizationMaint organizationMaint,
      OrganizationMaint_Parameters parameters,
      OrganizationMaint_Request request,
      out OrganizationMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      OrganizationMaint organizationMaint,
      OrganizationMaint_Parameters parameters,
      OrganizationMaint_Request request,
      out OrganizationMaint_Result result);

    [OperationContract]
    ResultStatus ProcessNameChange(
      UserProfile userProfile,
      OrganizationMaint organizationMaint,
      OrganizationMaint_Parameters parameters,
      OrganizationMaint_Request request,
      out OrganizationMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      OrganizationMaint organizationMaint,
      OrganizationMaint_Parameters parameters,
      OrganizationMaint_Request request,
      out OrganizationMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      OrganizationMaint organizationMaint,
      OrganizationMaint_Parameters parameters,
      OrganizationMaint_Request request,
      out OrganizationMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      OrganizationMaintMethod[] methods,
      OrganizationMaint_Request request,
      out OrganizationMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      OrganizationMaint organizationMaint,
      OrganizationMaint_Request request,
      out OrganizationMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      OrganizationMaint organizationMaint,
      OrganizationMaint_Request request,
      out OrganizationMaint_Result result);
  }
}
