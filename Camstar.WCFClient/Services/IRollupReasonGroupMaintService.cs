// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IRollupReasonGroupMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IRollupReasonGroupMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      RollupReasonGroupMaint rollupReasonGroupMaint,
      RollupReasonGroupMaint_Parameters parameters,
      RollupReasonGroupMaint_Request request,
      out RollupReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      RollupReasonGroupMaint rollupReasonGroupMaint,
      RollupReasonGroupMaint_Parameters parameters,
      RollupReasonGroupMaint_Request request,
      out RollupReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      RollupReasonGroupMaint rollupReasonGroupMaint,
      RollupReasonGroupMaint_Parameters parameters,
      RollupReasonGroupMaint_Request request,
      out RollupReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      RollupReasonGroupMaint rollupReasonGroupMaint,
      RollupReasonGroupMaint_Parameters parameters,
      RollupReasonGroupMaint_Request request,
      out RollupReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      RollupReasonGroupMaint rollupReasonGroupMaint,
      RollupReasonGroupMaint_LoadESigDetails_Parameters parameters,
      RollupReasonGroupMaint_Request request,
      out RollupReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      RollupReasonGroupMaint rollupReasonGroupMaint,
      RollupReasonGroupMaint_Parameters parameters,
      RollupReasonGroupMaint_Request request,
      out RollupReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      RollupReasonGroupMaint rollupReasonGroupMaint,
      RollupReasonGroupMaint_Parameters parameters,
      RollupReasonGroupMaint_Request request,
      out RollupReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      RollupReasonGroupMaint rollupReasonGroupMaint,
      RollupReasonGroupMaint_Parameters parameters,
      RollupReasonGroupMaint_Request request,
      out RollupReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      RollupReasonGroupMaint rollupReasonGroupMaint,
      RollupReasonGroupMaint_Parameters parameters,
      RollupReasonGroupMaint_Request request,
      out RollupReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      RollupReasonGroupMaintMethod[] methods,
      RollupReasonGroupMaint_Request request,
      out RollupReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      RollupReasonGroupMaint rollupReasonGroupMaint,
      RollupReasonGroupMaint_Request request,
      out RollupReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      RollupReasonGroupMaint rollupReasonGroupMaint,
      RollupReasonGroupMaint_Request request,
      out RollupReasonGroupMaint_Result result);
  }
}
