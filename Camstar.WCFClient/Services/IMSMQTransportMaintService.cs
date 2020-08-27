// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IMSMQTransportMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IMSMQTransportMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      MSMQTransportMaint mSMQTransportMaint,
      MSMQTransportMaint_Parameters parameters,
      MSMQTransportMaint_Request request,
      out MSMQTransportMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      MSMQTransportMaint mSMQTransportMaint,
      MSMQTransportMaint_Parameters parameters,
      MSMQTransportMaint_Request request,
      out MSMQTransportMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      MSMQTransportMaint mSMQTransportMaint,
      MSMQTransportMaint_Parameters parameters,
      MSMQTransportMaint_Request request,
      out MSMQTransportMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      MSMQTransportMaint mSMQTransportMaint,
      MSMQTransportMaint_Parameters parameters,
      MSMQTransportMaint_Request request,
      out MSMQTransportMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      MSMQTransportMaint mSMQTransportMaint,
      MSMQTransportMaint_LoadESigDetails_Parameters parameters,
      MSMQTransportMaint_Request request,
      out MSMQTransportMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      MSMQTransportMaint mSMQTransportMaint,
      MSMQTransportMaint_Parameters parameters,
      MSMQTransportMaint_Request request,
      out MSMQTransportMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      MSMQTransportMaint mSMQTransportMaint,
      MSMQTransportMaint_Parameters parameters,
      MSMQTransportMaint_Request request,
      out MSMQTransportMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      MSMQTransportMaint mSMQTransportMaint,
      MSMQTransportMaint_Parameters parameters,
      MSMQTransportMaint_Request request,
      out MSMQTransportMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      MSMQTransportMaint mSMQTransportMaint,
      MSMQTransportMaint_Parameters parameters,
      MSMQTransportMaint_Request request,
      out MSMQTransportMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      MSMQTransportMaintMethod[] methods,
      MSMQTransportMaint_Request request,
      out MSMQTransportMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      MSMQTransportMaint mSMQTransportMaint,
      MSMQTransportMaint_Request request,
      out MSMQTransportMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      MSMQTransportMaint mSMQTransportMaint,
      MSMQTransportMaint_Request request,
      out MSMQTransportMaint_Result result);
  }
}
