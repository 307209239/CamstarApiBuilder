// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IScaleGroupMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IScaleGroupMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      ScaleGroupMaint scaleGroupMaint,
      ScaleGroupMaint_Parameters parameters,
      ScaleGroupMaint_Request request,
      out ScaleGroupMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      ScaleGroupMaint scaleGroupMaint,
      ScaleGroupMaint_Parameters parameters,
      ScaleGroupMaint_Request request,
      out ScaleGroupMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ScaleGroupMaint scaleGroupMaint,
      ScaleGroupMaint_Parameters parameters,
      ScaleGroupMaint_Request request,
      out ScaleGroupMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ScaleGroupMaint scaleGroupMaint,
      ScaleGroupMaint_Parameters parameters,
      ScaleGroupMaint_Request request,
      out ScaleGroupMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ScaleGroupMaint scaleGroupMaint,
      ScaleGroupMaint_LoadESigDetails_Parameters parameters,
      ScaleGroupMaint_Request request,
      out ScaleGroupMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      ScaleGroupMaint scaleGroupMaint,
      ScaleGroupMaint_Parameters parameters,
      ScaleGroupMaint_Request request,
      out ScaleGroupMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      ScaleGroupMaint scaleGroupMaint,
      ScaleGroupMaint_Parameters parameters,
      ScaleGroupMaint_Request request,
      out ScaleGroupMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      ScaleGroupMaint scaleGroupMaint,
      ScaleGroupMaint_Parameters parameters,
      ScaleGroupMaint_Request request,
      out ScaleGroupMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      ScaleGroupMaint scaleGroupMaint,
      ScaleGroupMaint_Parameters parameters,
      ScaleGroupMaint_Request request,
      out ScaleGroupMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ScaleGroupMaintMethod[] methods,
      ScaleGroupMaint_Request request,
      out ScaleGroupMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ScaleGroupMaint scaleGroupMaint,
      ScaleGroupMaint_Request request,
      out ScaleGroupMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ScaleGroupMaint scaleGroupMaint,
      ScaleGroupMaint_Request request,
      out ScaleGroupMaint_Result result);
  }
}
