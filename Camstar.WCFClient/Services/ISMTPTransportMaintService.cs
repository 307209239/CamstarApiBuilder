// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ISMTPTransportMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ISMTPTransportMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      SMTPTransportMaint sMTPTransportMaint,
      SMTPTransportMaint_Parameters parameters,
      SMTPTransportMaint_Request request,
      out SMTPTransportMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      SMTPTransportMaint sMTPTransportMaint,
      SMTPTransportMaint_Parameters parameters,
      SMTPTransportMaint_Request request,
      out SMTPTransportMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      SMTPTransportMaint sMTPTransportMaint,
      SMTPTransportMaint_Parameters parameters,
      SMTPTransportMaint_Request request,
      out SMTPTransportMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      SMTPTransportMaint sMTPTransportMaint,
      SMTPTransportMaint_Parameters parameters,
      SMTPTransportMaint_Request request,
      out SMTPTransportMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      SMTPTransportMaint sMTPTransportMaint,
      SMTPTransportMaint_LoadESigDetails_Parameters parameters,
      SMTPTransportMaint_Request request,
      out SMTPTransportMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      SMTPTransportMaint sMTPTransportMaint,
      SMTPTransportMaint_Parameters parameters,
      SMTPTransportMaint_Request request,
      out SMTPTransportMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      SMTPTransportMaint sMTPTransportMaint,
      SMTPTransportMaint_Parameters parameters,
      SMTPTransportMaint_Request request,
      out SMTPTransportMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      SMTPTransportMaint sMTPTransportMaint,
      SMTPTransportMaint_Parameters parameters,
      SMTPTransportMaint_Request request,
      out SMTPTransportMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      SMTPTransportMaint sMTPTransportMaint,
      SMTPTransportMaint_Parameters parameters,
      SMTPTransportMaint_Request request,
      out SMTPTransportMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      SMTPTransportMaintMethod[] methods,
      SMTPTransportMaint_Request request,
      out SMTPTransportMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      SMTPTransportMaint sMTPTransportMaint,
      SMTPTransportMaint_Request request,
      out SMTPTransportMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      SMTPTransportMaint sMTPTransportMaint,
      SMTPTransportMaint_Request request,
      out SMTPTransportMaint_Result result);
  }
}
