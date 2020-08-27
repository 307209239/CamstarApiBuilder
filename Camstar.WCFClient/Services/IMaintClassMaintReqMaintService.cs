// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IMaintClassMaintReqMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IMaintClassMaintReqMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      MaintClassMaintReqMaint maintClassMaintReqMaint,
      MaintClassMaintReqMaint_Parameters parameters,
      MaintClassMaintReqMaint_Request request,
      out MaintClassMaintReqMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      MaintClassMaintReqMaint maintClassMaintReqMaint,
      MaintClassMaintReqMaint_Parameters parameters,
      MaintClassMaintReqMaint_Request request,
      out MaintClassMaintReqMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      MaintClassMaintReqMaint maintClassMaintReqMaint,
      MaintClassMaintReqMaint_Parameters parameters,
      MaintClassMaintReqMaint_Request request,
      out MaintClassMaintReqMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      MaintClassMaintReqMaint maintClassMaintReqMaint,
      MaintClassMaintReqMaint_Parameters parameters,
      MaintClassMaintReqMaint_Request request,
      out MaintClassMaintReqMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      MaintClassMaintReqMaint maintClassMaintReqMaint,
      MaintClassMaintReqMaint_LoadESigDetails_Parameters parameters,
      MaintClassMaintReqMaint_Request request,
      out MaintClassMaintReqMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      MaintClassMaintReqMaint maintClassMaintReqMaint,
      MaintClassMaintReqMaint_Parameters parameters,
      MaintClassMaintReqMaint_Request request,
      out MaintClassMaintReqMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      MaintClassMaintReqMaint maintClassMaintReqMaint,
      MaintClassMaintReqMaint_Parameters parameters,
      MaintClassMaintReqMaint_Request request,
      out MaintClassMaintReqMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      MaintClassMaintReqMaint maintClassMaintReqMaint,
      MaintClassMaintReqMaint_Parameters parameters,
      MaintClassMaintReqMaint_Request request,
      out MaintClassMaintReqMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      MaintClassMaintReqMaint maintClassMaintReqMaint,
      MaintClassMaintReqMaint_Parameters parameters,
      MaintClassMaintReqMaint_Request request,
      out MaintClassMaintReqMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      MaintClassMaintReqMaintMethod[] methods,
      MaintClassMaintReqMaint_Request request,
      out MaintClassMaintReqMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      MaintClassMaintReqMaint maintClassMaintReqMaint,
      MaintClassMaintReqMaint_Request request,
      out MaintClassMaintReqMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      MaintClassMaintReqMaint maintClassMaintReqMaint,
      MaintClassMaintReqMaint_Request request,
      out MaintClassMaintReqMaint_Result result);
  }
}
