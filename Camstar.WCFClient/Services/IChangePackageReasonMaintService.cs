// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IChangePackageReasonMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IChangePackageReasonMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      ChangePackageReasonMaint changePackageReasonMaint,
      ChangePackageReasonMaint_Parameters parameters,
      ChangePackageReasonMaint_Request request,
      out ChangePackageReasonMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      ChangePackageReasonMaint changePackageReasonMaint,
      ChangePackageReasonMaint_Parameters parameters,
      ChangePackageReasonMaint_Request request,
      out ChangePackageReasonMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ChangePackageReasonMaint changePackageReasonMaint,
      ChangePackageReasonMaint_Parameters parameters,
      ChangePackageReasonMaint_Request request,
      out ChangePackageReasonMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ChangePackageReasonMaint changePackageReasonMaint,
      ChangePackageReasonMaint_Parameters parameters,
      ChangePackageReasonMaint_Request request,
      out ChangePackageReasonMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ChangePackageReasonMaint changePackageReasonMaint,
      ChangePackageReasonMaint_LoadESigDetails_Parameters parameters,
      ChangePackageReasonMaint_Request request,
      out ChangePackageReasonMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      ChangePackageReasonMaint changePackageReasonMaint,
      ChangePackageReasonMaint_Parameters parameters,
      ChangePackageReasonMaint_Request request,
      out ChangePackageReasonMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      ChangePackageReasonMaint changePackageReasonMaint,
      ChangePackageReasonMaint_Parameters parameters,
      ChangePackageReasonMaint_Request request,
      out ChangePackageReasonMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      ChangePackageReasonMaint changePackageReasonMaint,
      ChangePackageReasonMaint_Parameters parameters,
      ChangePackageReasonMaint_Request request,
      out ChangePackageReasonMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      ChangePackageReasonMaint changePackageReasonMaint,
      ChangePackageReasonMaint_Parameters parameters,
      ChangePackageReasonMaint_Request request,
      out ChangePackageReasonMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ChangePackageReasonMaintMethod[] methods,
      ChangePackageReasonMaint_Request request,
      out ChangePackageReasonMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ChangePackageReasonMaint changePackageReasonMaint,
      ChangePackageReasonMaint_Request request,
      out ChangePackageReasonMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ChangePackageReasonMaint changePackageReasonMaint,
      ChangePackageReasonMaint_Request request,
      out ChangePackageReasonMaint_Result result);
  }
}
