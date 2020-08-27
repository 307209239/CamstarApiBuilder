// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IBillOfProcessMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IBillOfProcessMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      BillOfProcessMaint billOfProcessMaint,
      BillOfProcessMaint_Parameters parameters,
      BillOfProcessMaint_Request request,
      out BillOfProcessMaint_Result result);

    [OperationContract]
    ResultStatus DeleteAllRevisions(
      UserProfile userProfile,
      BillOfProcessMaint billOfProcessMaint,
      BillOfProcessMaint_Parameters parameters,
      BillOfProcessMaint_Request request,
      out BillOfProcessMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      BillOfProcessMaint billOfProcessMaint,
      BillOfProcessMaint_Parameters parameters,
      BillOfProcessMaint_Request request,
      out BillOfProcessMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      BillOfProcessMaint billOfProcessMaint,
      BillOfProcessMaint_Parameters parameters,
      BillOfProcessMaint_Request request,
      out BillOfProcessMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      BillOfProcessMaint billOfProcessMaint,
      BillOfProcessMaint_Parameters parameters,
      BillOfProcessMaint_Request request,
      out BillOfProcessMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      BillOfProcessMaint billOfProcessMaint,
      BillOfProcessMaint_LoadESigDetails_Parameters parameters,
      BillOfProcessMaint_Request request,
      out BillOfProcessMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      BillOfProcessMaint billOfProcessMaint,
      BillOfProcessMaint_Parameters parameters,
      BillOfProcessMaint_Request request,
      out BillOfProcessMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      BillOfProcessMaint billOfProcessMaint,
      BillOfProcessMaint_Parameters parameters,
      BillOfProcessMaint_Request request,
      out BillOfProcessMaint_Result result);

    [OperationContract]
    ResultStatus NewRev(
      UserProfile userProfile,
      BillOfProcessMaint billOfProcessMaint,
      BillOfProcessMaint_Parameters parameters,
      BillOfProcessMaint_Request request,
      out BillOfProcessMaint_Result result);

    [OperationContract]
    ResultStatus NewRevCopy(
      UserProfile userProfile,
      BillOfProcessMaint billOfProcessMaint,
      BillOfProcessMaint_Parameters parameters,
      BillOfProcessMaint_Request request,
      out BillOfProcessMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      BillOfProcessMaint billOfProcessMaint,
      BillOfProcessMaint_Parameters parameters,
      BillOfProcessMaint_Request request,
      out BillOfProcessMaint_Result result);

    [OperationContract]
    ResultStatus SaveAsRev(
      UserProfile userProfile,
      BillOfProcessMaint billOfProcessMaint,
      BillOfProcessMaint_Parameters parameters,
      BillOfProcessMaint_Request request,
      out BillOfProcessMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      BillOfProcessMaint billOfProcessMaint,
      BillOfProcessMaint_Parameters parameters,
      BillOfProcessMaint_Request request,
      out BillOfProcessMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      BillOfProcessMaintMethod[] methods,
      BillOfProcessMaint_Request request,
      out BillOfProcessMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      BillOfProcessMaint billOfProcessMaint,
      BillOfProcessMaint_Request request,
      out BillOfProcessMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      BillOfProcessMaint billOfProcessMaint,
      BillOfProcessMaint_Request request,
      out BillOfProcessMaint_Result result);
  }
}
