// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IRegulatoryAgencyMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IRegulatoryAgencyMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      RegulatoryAgencyMaint regulatoryAgencyMaint,
      RegulatoryAgencyMaint_Parameters parameters,
      RegulatoryAgencyMaint_Request request,
      out RegulatoryAgencyMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      RegulatoryAgencyMaint regulatoryAgencyMaint,
      RegulatoryAgencyMaint_Parameters parameters,
      RegulatoryAgencyMaint_Request request,
      out RegulatoryAgencyMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      RegulatoryAgencyMaint regulatoryAgencyMaint,
      RegulatoryAgencyMaint_Parameters parameters,
      RegulatoryAgencyMaint_Request request,
      out RegulatoryAgencyMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      RegulatoryAgencyMaint regulatoryAgencyMaint,
      RegulatoryAgencyMaint_Parameters parameters,
      RegulatoryAgencyMaint_Request request,
      out RegulatoryAgencyMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      RegulatoryAgencyMaint regulatoryAgencyMaint,
      RegulatoryAgencyMaint_LoadESigDetails_Parameters parameters,
      RegulatoryAgencyMaint_Request request,
      out RegulatoryAgencyMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      RegulatoryAgencyMaint regulatoryAgencyMaint,
      RegulatoryAgencyMaint_Parameters parameters,
      RegulatoryAgencyMaint_Request request,
      out RegulatoryAgencyMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      RegulatoryAgencyMaint regulatoryAgencyMaint,
      RegulatoryAgencyMaint_Parameters parameters,
      RegulatoryAgencyMaint_Request request,
      out RegulatoryAgencyMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      RegulatoryAgencyMaint regulatoryAgencyMaint,
      RegulatoryAgencyMaint_Parameters parameters,
      RegulatoryAgencyMaint_Request request,
      out RegulatoryAgencyMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      RegulatoryAgencyMaint regulatoryAgencyMaint,
      RegulatoryAgencyMaint_Parameters parameters,
      RegulatoryAgencyMaint_Request request,
      out RegulatoryAgencyMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      RegulatoryAgencyMaintMethod[] methods,
      RegulatoryAgencyMaint_Request request,
      out RegulatoryAgencyMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      RegulatoryAgencyMaint regulatoryAgencyMaint,
      RegulatoryAgencyMaint_Request request,
      out RegulatoryAgencyMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      RegulatoryAgencyMaint regulatoryAgencyMaint,
      RegulatoryAgencyMaint_Request request,
      out RegulatoryAgencyMaint_Result result);
  }
}
