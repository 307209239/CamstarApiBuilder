// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IDataTransportMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IDataTransportMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      DataTransportMaint dataTransportMaint,
      DataTransportMaint_Parameters parameters,
      DataTransportMaint_Request request,
      out DataTransportMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      DataTransportMaint dataTransportMaint,
      DataTransportMaint_Parameters parameters,
      DataTransportMaint_Request request,
      out DataTransportMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      DataTransportMaint dataTransportMaint,
      DataTransportMaint_Parameters parameters,
      DataTransportMaint_Request request,
      out DataTransportMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      DataTransportMaint dataTransportMaint,
      DataTransportMaint_Parameters parameters,
      DataTransportMaint_Request request,
      out DataTransportMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      DataTransportMaint dataTransportMaint,
      DataTransportMaint_LoadESigDetails_Parameters parameters,
      DataTransportMaint_Request request,
      out DataTransportMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      DataTransportMaint dataTransportMaint,
      DataTransportMaint_Parameters parameters,
      DataTransportMaint_Request request,
      out DataTransportMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      DataTransportMaint dataTransportMaint,
      DataTransportMaint_Parameters parameters,
      DataTransportMaint_Request request,
      out DataTransportMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      DataTransportMaint dataTransportMaint,
      DataTransportMaint_Parameters parameters,
      DataTransportMaint_Request request,
      out DataTransportMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      DataTransportMaint dataTransportMaint,
      DataTransportMaint_Parameters parameters,
      DataTransportMaint_Request request,
      out DataTransportMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      DataTransportMaintMethod[] methods,
      DataTransportMaint_Request request,
      out DataTransportMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      DataTransportMaint dataTransportMaint,
      DataTransportMaint_Request request,
      out DataTransportMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      DataTransportMaint dataTransportMaint,
      DataTransportMaint_Request request,
      out DataTransportMaint_Result result);
  }
}
