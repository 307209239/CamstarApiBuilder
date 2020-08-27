// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IBusinessProcessSpecMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IBusinessProcessSpecMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      BusinessProcessSpecMaint businessProcessSpecMaint,
      BusinessProcessSpecMaint_Parameters parameters,
      BusinessProcessSpecMaint_Request request,
      out BusinessProcessSpecMaint_Result result);

    [OperationContract]
    ResultStatus DeleteAllRevisions(
      UserProfile userProfile,
      BusinessProcessSpecMaint businessProcessSpecMaint,
      BusinessProcessSpecMaint_Parameters parameters,
      BusinessProcessSpecMaint_Request request,
      out BusinessProcessSpecMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      BusinessProcessSpecMaint businessProcessSpecMaint,
      BusinessProcessSpecMaint_Parameters parameters,
      BusinessProcessSpecMaint_Request request,
      out BusinessProcessSpecMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      BusinessProcessSpecMaint businessProcessSpecMaint,
      BusinessProcessSpecMaint_Parameters parameters,
      BusinessProcessSpecMaint_Request request,
      out BusinessProcessSpecMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      BusinessProcessSpecMaint businessProcessSpecMaint,
      BusinessProcessSpecMaint_Parameters parameters,
      BusinessProcessSpecMaint_Request request,
      out BusinessProcessSpecMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      BusinessProcessSpecMaint businessProcessSpecMaint,
      BusinessProcessSpecMaint_LoadESigDetails_Parameters parameters,
      BusinessProcessSpecMaint_Request request,
      out BusinessProcessSpecMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      BusinessProcessSpecMaint businessProcessSpecMaint,
      BusinessProcessSpecMaint_Parameters parameters,
      BusinessProcessSpecMaint_Request request,
      out BusinessProcessSpecMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      BusinessProcessSpecMaint businessProcessSpecMaint,
      BusinessProcessSpecMaint_Parameters parameters,
      BusinessProcessSpecMaint_Request request,
      out BusinessProcessSpecMaint_Result result);

    [OperationContract]
    ResultStatus NewRev(
      UserProfile userProfile,
      BusinessProcessSpecMaint businessProcessSpecMaint,
      BusinessProcessSpecMaint_Parameters parameters,
      BusinessProcessSpecMaint_Request request,
      out BusinessProcessSpecMaint_Result result);

    [OperationContract]
    ResultStatus NewRevCopy(
      UserProfile userProfile,
      BusinessProcessSpecMaint businessProcessSpecMaint,
      BusinessProcessSpecMaint_Parameters parameters,
      BusinessProcessSpecMaint_Request request,
      out BusinessProcessSpecMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      BusinessProcessSpecMaint businessProcessSpecMaint,
      BusinessProcessSpecMaint_Parameters parameters,
      BusinessProcessSpecMaint_Request request,
      out BusinessProcessSpecMaint_Result result);

    [OperationContract]
    ResultStatus SaveAsRev(
      UserProfile userProfile,
      BusinessProcessSpecMaint businessProcessSpecMaint,
      BusinessProcessSpecMaint_Parameters parameters,
      BusinessProcessSpecMaint_Request request,
      out BusinessProcessSpecMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      BusinessProcessSpecMaint businessProcessSpecMaint,
      BusinessProcessSpecMaint_Parameters parameters,
      BusinessProcessSpecMaint_Request request,
      out BusinessProcessSpecMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      BusinessProcessSpecMaintMethod[] methods,
      BusinessProcessSpecMaint_Request request,
      out BusinessProcessSpecMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      BusinessProcessSpecMaint businessProcessSpecMaint,
      BusinessProcessSpecMaint_Request request,
      out BusinessProcessSpecMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      BusinessProcessSpecMaint businessProcessSpecMaint,
      BusinessProcessSpecMaint_Request request,
      out BusinessProcessSpecMaint_Result result);
  }
}
