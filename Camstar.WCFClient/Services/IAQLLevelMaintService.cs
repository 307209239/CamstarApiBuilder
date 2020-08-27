// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IAQLLevelMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IAQLLevelMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      AQLLevelMaint aQLLevelMaint,
      AQLLevelMaint_Parameters parameters,
      AQLLevelMaint_Request request,
      out AQLLevelMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      AQLLevelMaint aQLLevelMaint,
      AQLLevelMaint_Parameters parameters,
      AQLLevelMaint_Request request,
      out AQLLevelMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      AQLLevelMaint aQLLevelMaint,
      AQLLevelMaint_Parameters parameters,
      AQLLevelMaint_Request request,
      out AQLLevelMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      AQLLevelMaint aQLLevelMaint,
      AQLLevelMaint_Parameters parameters,
      AQLLevelMaint_Request request,
      out AQLLevelMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      AQLLevelMaint aQLLevelMaint,
      AQLLevelMaint_LoadESigDetails_Parameters parameters,
      AQLLevelMaint_Request request,
      out AQLLevelMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      AQLLevelMaint aQLLevelMaint,
      AQLLevelMaint_Parameters parameters,
      AQLLevelMaint_Request request,
      out AQLLevelMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      AQLLevelMaint aQLLevelMaint,
      AQLLevelMaint_Parameters parameters,
      AQLLevelMaint_Request request,
      out AQLLevelMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      AQLLevelMaint aQLLevelMaint,
      AQLLevelMaint_Parameters parameters,
      AQLLevelMaint_Request request,
      out AQLLevelMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      AQLLevelMaint aQLLevelMaint,
      AQLLevelMaint_Parameters parameters,
      AQLLevelMaint_Request request,
      out AQLLevelMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      AQLLevelMaintMethod[] methods,
      AQLLevelMaint_Request request,
      out AQLLevelMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      AQLLevelMaint aQLLevelMaint,
      AQLLevelMaint_Request request,
      out AQLLevelMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      AQLLevelMaint aQLLevelMaint,
      AQLLevelMaint_Request request,
      out AQLLevelMaint_Result result);
  }
}
