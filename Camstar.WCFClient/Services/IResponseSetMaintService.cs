// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IResponseSetMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IResponseSetMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      ResponseSetMaint responseSetMaint,
      ResponseSetMaint_Parameters parameters,
      ResponseSetMaint_Request request,
      out ResponseSetMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      ResponseSetMaint responseSetMaint,
      ResponseSetMaint_Parameters parameters,
      ResponseSetMaint_Request request,
      out ResponseSetMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ResponseSetMaint responseSetMaint,
      ResponseSetMaint_Parameters parameters,
      ResponseSetMaint_Request request,
      out ResponseSetMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ResponseSetMaint responseSetMaint,
      ResponseSetMaint_Parameters parameters,
      ResponseSetMaint_Request request,
      out ResponseSetMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ResponseSetMaint responseSetMaint,
      ResponseSetMaint_LoadESigDetails_Parameters parameters,
      ResponseSetMaint_Request request,
      out ResponseSetMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      ResponseSetMaint responseSetMaint,
      ResponseSetMaint_Parameters parameters,
      ResponseSetMaint_Request request,
      out ResponseSetMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      ResponseSetMaint responseSetMaint,
      ResponseSetMaint_Parameters parameters,
      ResponseSetMaint_Request request,
      out ResponseSetMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      ResponseSetMaint responseSetMaint,
      ResponseSetMaint_Parameters parameters,
      ResponseSetMaint_Request request,
      out ResponseSetMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      ResponseSetMaint responseSetMaint,
      ResponseSetMaint_Parameters parameters,
      ResponseSetMaint_Request request,
      out ResponseSetMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ResponseSetMaintMethod[] methods,
      ResponseSetMaint_Request request,
      out ResponseSetMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ResponseSetMaint responseSetMaint,
      ResponseSetMaint_Request request,
      out ResponseSetMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ResponseSetMaint responseSetMaint,
      ResponseSetMaint_Request request,
      out ResponseSetMaint_Result result);
  }
}
