// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IEMailDistributionMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IEMailDistributionMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      EMailDistributionMaint eMailDistributionMaint,
      EMailDistributionMaint_Parameters parameters,
      EMailDistributionMaint_Request request,
      out EMailDistributionMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      EMailDistributionMaint eMailDistributionMaint,
      EMailDistributionMaint_Parameters parameters,
      EMailDistributionMaint_Request request,
      out EMailDistributionMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      EMailDistributionMaint eMailDistributionMaint,
      EMailDistributionMaint_Parameters parameters,
      EMailDistributionMaint_Request request,
      out EMailDistributionMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      EMailDistributionMaint eMailDistributionMaint,
      EMailDistributionMaint_Parameters parameters,
      EMailDistributionMaint_Request request,
      out EMailDistributionMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      EMailDistributionMaint eMailDistributionMaint,
      EMailDistributionMaint_LoadESigDetails_Parameters parameters,
      EMailDistributionMaint_Request request,
      out EMailDistributionMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      EMailDistributionMaint eMailDistributionMaint,
      EMailDistributionMaint_Parameters parameters,
      EMailDistributionMaint_Request request,
      out EMailDistributionMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      EMailDistributionMaint eMailDistributionMaint,
      EMailDistributionMaint_Parameters parameters,
      EMailDistributionMaint_Request request,
      out EMailDistributionMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      EMailDistributionMaint eMailDistributionMaint,
      EMailDistributionMaint_Parameters parameters,
      EMailDistributionMaint_Request request,
      out EMailDistributionMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      EMailDistributionMaint eMailDistributionMaint,
      EMailDistributionMaint_Parameters parameters,
      EMailDistributionMaint_Request request,
      out EMailDistributionMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      EMailDistributionMaintMethod[] methods,
      EMailDistributionMaint_Request request,
      out EMailDistributionMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      EMailDistributionMaint eMailDistributionMaint,
      EMailDistributionMaint_Request request,
      out EMailDistributionMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      EMailDistributionMaint eMailDistributionMaint,
      EMailDistributionMaint_Request request,
      out EMailDistributionMaint_Result result);
  }
}
