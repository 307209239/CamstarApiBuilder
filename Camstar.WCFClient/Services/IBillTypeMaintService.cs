// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IBillTypeMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IBillTypeMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      BillTypeMaint billTypeMaint,
      BillTypeMaint_Parameters parameters,
      BillTypeMaint_Request request,
      out BillTypeMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      BillTypeMaint billTypeMaint,
      BillTypeMaint_Parameters parameters,
      BillTypeMaint_Request request,
      out BillTypeMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      BillTypeMaint billTypeMaint,
      BillTypeMaint_Parameters parameters,
      BillTypeMaint_Request request,
      out BillTypeMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      BillTypeMaint billTypeMaint,
      BillTypeMaint_Parameters parameters,
      BillTypeMaint_Request request,
      out BillTypeMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      BillTypeMaint billTypeMaint,
      BillTypeMaint_LoadESigDetails_Parameters parameters,
      BillTypeMaint_Request request,
      out BillTypeMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      BillTypeMaint billTypeMaint,
      BillTypeMaint_Parameters parameters,
      BillTypeMaint_Request request,
      out BillTypeMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      BillTypeMaint billTypeMaint,
      BillTypeMaint_Parameters parameters,
      BillTypeMaint_Request request,
      out BillTypeMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      BillTypeMaint billTypeMaint,
      BillTypeMaint_Parameters parameters,
      BillTypeMaint_Request request,
      out BillTypeMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      BillTypeMaint billTypeMaint,
      BillTypeMaint_Parameters parameters,
      BillTypeMaint_Request request,
      out BillTypeMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      BillTypeMaintMethod[] methods,
      BillTypeMaint_Request request,
      out BillTypeMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      BillTypeMaint billTypeMaint,
      BillTypeMaint_Request request,
      out BillTypeMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      BillTypeMaint billTypeMaint,
      BillTypeMaint_Request request,
      out BillTypeMaint_Result result);
  }
}
