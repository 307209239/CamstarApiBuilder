// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IChangeMgtSpecMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IChangeMgtSpecMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      ChangeMgtSpecMaint changeMgtSpecMaint,
      ChangeMgtSpecMaint_Parameters parameters,
      ChangeMgtSpecMaint_Request request,
      out ChangeMgtSpecMaint_Result result);

    [OperationContract]
    ResultStatus DeleteAllRevisions(
      UserProfile userProfile,
      ChangeMgtSpecMaint changeMgtSpecMaint,
      ChangeMgtSpecMaint_Parameters parameters,
      ChangeMgtSpecMaint_Request request,
      out ChangeMgtSpecMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      ChangeMgtSpecMaint changeMgtSpecMaint,
      ChangeMgtSpecMaint_Parameters parameters,
      ChangeMgtSpecMaint_Request request,
      out ChangeMgtSpecMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ChangeMgtSpecMaint changeMgtSpecMaint,
      ChangeMgtSpecMaint_Parameters parameters,
      ChangeMgtSpecMaint_Request request,
      out ChangeMgtSpecMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ChangeMgtSpecMaint changeMgtSpecMaint,
      ChangeMgtSpecMaint_Parameters parameters,
      ChangeMgtSpecMaint_Request request,
      out ChangeMgtSpecMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ChangeMgtSpecMaint changeMgtSpecMaint,
      ChangeMgtSpecMaint_LoadESigDetails_Parameters parameters,
      ChangeMgtSpecMaint_Request request,
      out ChangeMgtSpecMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      ChangeMgtSpecMaint changeMgtSpecMaint,
      ChangeMgtSpecMaint_Parameters parameters,
      ChangeMgtSpecMaint_Request request,
      out ChangeMgtSpecMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      ChangeMgtSpecMaint changeMgtSpecMaint,
      ChangeMgtSpecMaint_Parameters parameters,
      ChangeMgtSpecMaint_Request request,
      out ChangeMgtSpecMaint_Result result);

    [OperationContract]
    ResultStatus NewRev(
      UserProfile userProfile,
      ChangeMgtSpecMaint changeMgtSpecMaint,
      ChangeMgtSpecMaint_Parameters parameters,
      ChangeMgtSpecMaint_Request request,
      out ChangeMgtSpecMaint_Result result);

    [OperationContract]
    ResultStatus NewRevCopy(
      UserProfile userProfile,
      ChangeMgtSpecMaint changeMgtSpecMaint,
      ChangeMgtSpecMaint_Parameters parameters,
      ChangeMgtSpecMaint_Request request,
      out ChangeMgtSpecMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      ChangeMgtSpecMaint changeMgtSpecMaint,
      ChangeMgtSpecMaint_Parameters parameters,
      ChangeMgtSpecMaint_Request request,
      out ChangeMgtSpecMaint_Result result);

    [OperationContract]
    ResultStatus SaveAsRev(
      UserProfile userProfile,
      ChangeMgtSpecMaint changeMgtSpecMaint,
      ChangeMgtSpecMaint_Parameters parameters,
      ChangeMgtSpecMaint_Request request,
      out ChangeMgtSpecMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      ChangeMgtSpecMaint changeMgtSpecMaint,
      ChangeMgtSpecMaint_Parameters parameters,
      ChangeMgtSpecMaint_Request request,
      out ChangeMgtSpecMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ChangeMgtSpecMaintMethod[] methods,
      ChangeMgtSpecMaint_Request request,
      out ChangeMgtSpecMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ChangeMgtSpecMaint changeMgtSpecMaint,
      ChangeMgtSpecMaint_Request request,
      out ChangeMgtSpecMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ChangeMgtSpecMaint changeMgtSpecMaint,
      ChangeMgtSpecMaint_Request request,
      out ChangeMgtSpecMaint_Result result);
  }
}
