// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ICARSeverityMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ICARSeverityMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      CARSeverityMaint cARSeverityMaint,
      CARSeverityMaint_Parameters parameters,
      CARSeverityMaint_Request request,
      out CARSeverityMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      CARSeverityMaint cARSeverityMaint,
      CARSeverityMaint_Parameters parameters,
      CARSeverityMaint_Request request,
      out CARSeverityMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      CARSeverityMaint cARSeverityMaint,
      CARSeverityMaint_Parameters parameters,
      CARSeverityMaint_Request request,
      out CARSeverityMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      CARSeverityMaint cARSeverityMaint,
      CARSeverityMaint_Parameters parameters,
      CARSeverityMaint_Request request,
      out CARSeverityMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      CARSeverityMaint cARSeverityMaint,
      CARSeverityMaint_LoadESigDetails_Parameters parameters,
      CARSeverityMaint_Request request,
      out CARSeverityMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      CARSeverityMaint cARSeverityMaint,
      CARSeverityMaint_Parameters parameters,
      CARSeverityMaint_Request request,
      out CARSeverityMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      CARSeverityMaint cARSeverityMaint,
      CARSeverityMaint_Parameters parameters,
      CARSeverityMaint_Request request,
      out CARSeverityMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      CARSeverityMaint cARSeverityMaint,
      CARSeverityMaint_Parameters parameters,
      CARSeverityMaint_Request request,
      out CARSeverityMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      CARSeverityMaint cARSeverityMaint,
      CARSeverityMaint_Parameters parameters,
      CARSeverityMaint_Request request,
      out CARSeverityMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      CARSeverityMaintMethod[] methods,
      CARSeverityMaint_Request request,
      out CARSeverityMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      CARSeverityMaint cARSeverityMaint,
      CARSeverityMaint_Request request,
      out CARSeverityMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      CARSeverityMaint cARSeverityMaint,
      CARSeverityMaint_Request request,
      out CARSeverityMaint_Result result);
  }
}
