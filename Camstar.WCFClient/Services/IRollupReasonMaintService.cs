// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IRollupReasonMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IRollupReasonMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      RollupReasonMaint rollupReasonMaint,
      RollupReasonMaint_Parameters parameters,
      RollupReasonMaint_Request request,
      out RollupReasonMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      RollupReasonMaint rollupReasonMaint,
      RollupReasonMaint_Parameters parameters,
      RollupReasonMaint_Request request,
      out RollupReasonMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      RollupReasonMaint rollupReasonMaint,
      RollupReasonMaint_Parameters parameters,
      RollupReasonMaint_Request request,
      out RollupReasonMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      RollupReasonMaint rollupReasonMaint,
      RollupReasonMaint_Parameters parameters,
      RollupReasonMaint_Request request,
      out RollupReasonMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      RollupReasonMaint rollupReasonMaint,
      RollupReasonMaint_LoadESigDetails_Parameters parameters,
      RollupReasonMaint_Request request,
      out RollupReasonMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      RollupReasonMaint rollupReasonMaint,
      RollupReasonMaint_Parameters parameters,
      RollupReasonMaint_Request request,
      out RollupReasonMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      RollupReasonMaint rollupReasonMaint,
      RollupReasonMaint_Parameters parameters,
      RollupReasonMaint_Request request,
      out RollupReasonMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      RollupReasonMaint rollupReasonMaint,
      RollupReasonMaint_Parameters parameters,
      RollupReasonMaint_Request request,
      out RollupReasonMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      RollupReasonMaint rollupReasonMaint,
      RollupReasonMaint_Parameters parameters,
      RollupReasonMaint_Request request,
      out RollupReasonMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      RollupReasonMaintMethod[] methods,
      RollupReasonMaint_Request request,
      out RollupReasonMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      RollupReasonMaint rollupReasonMaint,
      RollupReasonMaint_Request request,
      out RollupReasonMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      RollupReasonMaint rollupReasonMaint,
      RollupReasonMaint_Request request,
      out RollupReasonMaint_Result result);
  }
}
