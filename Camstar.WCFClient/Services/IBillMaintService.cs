// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IBillMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IBillMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      BillMaint billMaint,
      BillMaint_Parameters parameters,
      BillMaint_Request request,
      out BillMaint_Result result);

    [OperationContract]
    ResultStatus DeleteAllRevisions(
      UserProfile userProfile,
      BillMaint billMaint,
      BillMaint_Parameters parameters,
      BillMaint_Request request,
      out BillMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      BillMaint billMaint,
      BillMaint_Parameters parameters,
      BillMaint_Request request,
      out BillMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      BillMaint billMaint,
      BillMaint_Parameters parameters,
      BillMaint_Request request,
      out BillMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      BillMaint billMaint,
      BillMaint_Parameters parameters,
      BillMaint_Request request,
      out BillMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      BillMaint billMaint,
      BillMaint_LoadESigDetails_Parameters parameters,
      BillMaint_Request request,
      out BillMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      BillMaint billMaint,
      BillMaint_Parameters parameters,
      BillMaint_Request request,
      out BillMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      BillMaint billMaint,
      BillMaint_Parameters parameters,
      BillMaint_Request request,
      out BillMaint_Result result);

    [OperationContract]
    ResultStatus NewRev(
      UserProfile userProfile,
      BillMaint billMaint,
      BillMaint_Parameters parameters,
      BillMaint_Request request,
      out BillMaint_Result result);

    [OperationContract]
    ResultStatus NewRevCopy(
      UserProfile userProfile,
      BillMaint billMaint,
      BillMaint_Parameters parameters,
      BillMaint_Request request,
      out BillMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      BillMaint billMaint,
      BillMaint_Parameters parameters,
      BillMaint_Request request,
      out BillMaint_Result result);

    [OperationContract]
    ResultStatus SaveAsRev(
      UserProfile userProfile,
      BillMaint billMaint,
      BillMaint_Parameters parameters,
      BillMaint_Request request,
      out BillMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      BillMaint billMaint,
      BillMaint_Parameters parameters,
      BillMaint_Request request,
      out BillMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      BillMaintMethod[] methods,
      BillMaint_Request request,
      out BillMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      BillMaint billMaint,
      BillMaint_Request request,
      out BillMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      BillMaint billMaint,
      BillMaint_Request request,
      out BillMaint_Result result);
  }
}
