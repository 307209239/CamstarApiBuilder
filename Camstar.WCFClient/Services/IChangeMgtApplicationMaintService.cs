// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IChangeMgtApplicationMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IChangeMgtApplicationMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      ChangeMgtApplicationMaint changeMgtApplicationMaint,
      ChangeMgtApplicationMaint_Parameters parameters,
      ChangeMgtApplicationMaint_Request request,
      out ChangeMgtApplicationMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      ChangeMgtApplicationMaint changeMgtApplicationMaint,
      ChangeMgtApplicationMaint_Parameters parameters,
      ChangeMgtApplicationMaint_Request request,
      out ChangeMgtApplicationMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ChangeMgtApplicationMaint changeMgtApplicationMaint,
      ChangeMgtApplicationMaint_Parameters parameters,
      ChangeMgtApplicationMaint_Request request,
      out ChangeMgtApplicationMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ChangeMgtApplicationMaint changeMgtApplicationMaint,
      ChangeMgtApplicationMaint_Parameters parameters,
      ChangeMgtApplicationMaint_Request request,
      out ChangeMgtApplicationMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ChangeMgtApplicationMaint changeMgtApplicationMaint,
      ChangeMgtApplicationMaint_LoadESigDetails_Parameters parameters,
      ChangeMgtApplicationMaint_Request request,
      out ChangeMgtApplicationMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      ChangeMgtApplicationMaint changeMgtApplicationMaint,
      ChangeMgtApplicationMaint_Parameters parameters,
      ChangeMgtApplicationMaint_Request request,
      out ChangeMgtApplicationMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      ChangeMgtApplicationMaint changeMgtApplicationMaint,
      ChangeMgtApplicationMaint_Parameters parameters,
      ChangeMgtApplicationMaint_Request request,
      out ChangeMgtApplicationMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      ChangeMgtApplicationMaint changeMgtApplicationMaint,
      ChangeMgtApplicationMaint_Parameters parameters,
      ChangeMgtApplicationMaint_Request request,
      out ChangeMgtApplicationMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      ChangeMgtApplicationMaint changeMgtApplicationMaint,
      ChangeMgtApplicationMaint_Parameters parameters,
      ChangeMgtApplicationMaint_Request request,
      out ChangeMgtApplicationMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ChangeMgtApplicationMaintMethod[] methods,
      ChangeMgtApplicationMaint_Request request,
      out ChangeMgtApplicationMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ChangeMgtApplicationMaint changeMgtApplicationMaint,
      ChangeMgtApplicationMaint_Request request,
      out ChangeMgtApplicationMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ChangeMgtApplicationMaint changeMgtApplicationMaint,
      ChangeMgtApplicationMaint_Request request,
      out ChangeMgtApplicationMaint_Result result);
  }
}
