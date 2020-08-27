// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ContainerGroupMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ContainerGroupMaintService : ObjectGroupMaintBase
  {
    public ContainerGroupMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IContainerGroupMaintService), userProfile);
    }

    public ResultStatus Delete(
      ContainerGroupMaint containerGroupMaint,
      ContainerGroupMaint_Parameters parameters,
      ContainerGroupMaint_Request request,
      out ContainerGroupMaint_Result result)
    {
      result = (ContainerGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) containerGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerGroupMaintService) this._Channel).Delete(this._UserProfile, containerGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ContainerGroupMaintMethod(containerGroupMaint, ContainerGroupMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) containerGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ContainerGroupMaint) null, (ContainerGroupMaint_Parameters) null, (ContainerGroupMaint_Request) null, out ContainerGroupMaint_Result _);
    }

    public ResultStatus Delete(ContainerGroupMaint containerGroupMaint)
    {
      return this.Delete(containerGroupMaint, (ContainerGroupMaint_Parameters) null, (ContainerGroupMaint_Request) null, out ContainerGroupMaint_Result _);
    }

    public ResultStatus Delete(
      ContainerGroupMaint containerGroupMaint,
      ContainerGroupMaint_Request request,
      out ContainerGroupMaint_Result result)
    {
      return this.Delete(containerGroupMaint, (ContainerGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ContainerGroupMaint containerGroupMaint,
      ContainerGroupMaint_Parameters parameters,
      ContainerGroupMaint_Request request,
      out ContainerGroupMaint_Result result)
    {
      result = (ContainerGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) containerGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerGroupMaintService) this._Channel).Freeze(this._UserProfile, containerGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ContainerGroupMaintMethod(containerGroupMaint, ContainerGroupMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) containerGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ContainerGroupMaint) null, (ContainerGroupMaint_Parameters) null, (ContainerGroupMaint_Request) null, out ContainerGroupMaint_Result _);
    }

    public ResultStatus Freeze(ContainerGroupMaint containerGroupMaint)
    {
      return this.Freeze(containerGroupMaint, (ContainerGroupMaint_Parameters) null, (ContainerGroupMaint_Request) null, out ContainerGroupMaint_Result _);
    }

    public ResultStatus Freeze(
      ContainerGroupMaint containerGroupMaint,
      ContainerGroupMaint_Request request,
      out ContainerGroupMaint_Result result)
    {
      return this.Freeze(containerGroupMaint, (ContainerGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ContainerGroupMaint containerGroupMaint,
      ContainerGroupMaint_Parameters parameters,
      ContainerGroupMaint_Request request,
      out ContainerGroupMaint_Result result)
    {
      result = (ContainerGroupMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) containerGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerGroupMaintService) this._Channel).GetWIPMsgs(this._UserProfile, containerGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ContainerGroupMaintMethod(containerGroupMaint, ContainerGroupMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) containerGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ContainerGroupMaint) null, (ContainerGroupMaint_Parameters) null, (ContainerGroupMaint_Request) null, out ContainerGroupMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(ContainerGroupMaint containerGroupMaint)
    {
      return this.GetWIPMsgs(containerGroupMaint, (ContainerGroupMaint_Parameters) null, (ContainerGroupMaint_Request) null, out ContainerGroupMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ContainerGroupMaint containerGroupMaint,
      ContainerGroupMaint_Request request,
      out ContainerGroupMaint_Result result)
    {
      return this.GetWIPMsgs(containerGroupMaint, (ContainerGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ContainerGroupMaint containerGroupMaint,
      ContainerGroupMaint_Parameters parameters,
      ContainerGroupMaint_Request request,
      out ContainerGroupMaint_Result result)
    {
      result = (ContainerGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) containerGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerGroupMaintService) this._Channel).Load(this._UserProfile, containerGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ContainerGroupMaintMethod(containerGroupMaint, ContainerGroupMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) containerGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ContainerGroupMaint) null, (ContainerGroupMaint_Parameters) null, (ContainerGroupMaint_Request) null, out ContainerGroupMaint_Result _);
    }

    public ResultStatus Load(ContainerGroupMaint containerGroupMaint)
    {
      return this.Load(containerGroupMaint, (ContainerGroupMaint_Parameters) null, (ContainerGroupMaint_Request) null, out ContainerGroupMaint_Result _);
    }

    public ResultStatus Load(
      ContainerGroupMaint containerGroupMaint,
      ContainerGroupMaint_Request request,
      out ContainerGroupMaint_Result result)
    {
      return this.Load(containerGroupMaint, (ContainerGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ContainerGroupMaint containerGroupMaint,
      ContainerGroupMaint_LoadESigDetails_Parameters parameters,
      ContainerGroupMaint_Request request,
      out ContainerGroupMaint_Result result)
    {
      result = (ContainerGroupMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) containerGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerGroupMaintService) this._Channel).LoadESigDetails(this._UserProfile, containerGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ContainerGroupMaintMethod(containerGroupMaint, ContainerGroupMaintMethods.LoadESigDetails, (ContainerGroupMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) containerGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ContainerGroupMaint) null, (ContainerGroupMaint_LoadESigDetails_Parameters) null, (ContainerGroupMaint_Request) null, out ContainerGroupMaint_Result _);
    }

    public ResultStatus LoadESigDetails(ContainerGroupMaint containerGroupMaint)
    {
      return this.LoadESigDetails(containerGroupMaint, (ContainerGroupMaint_LoadESigDetails_Parameters) null, (ContainerGroupMaint_Request) null, out ContainerGroupMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ContainerGroupMaint containerGroupMaint,
      ContainerGroupMaint_Request request,
      out ContainerGroupMaint_Result result)
    {
      return this.LoadESigDetails(containerGroupMaint, (ContainerGroupMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ContainerGroupMaint containerGroupMaint,
      ContainerGroupMaint_Parameters parameters,
      ContainerGroupMaint_Request request,
      out ContainerGroupMaint_Result result)
    {
      result = (ContainerGroupMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) containerGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerGroupMaintService) this._Channel).New(this._UserProfile, containerGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ContainerGroupMaintMethod(containerGroupMaint, ContainerGroupMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) containerGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ContainerGroupMaint) null, (ContainerGroupMaint_Parameters) null, (ContainerGroupMaint_Request) null, out ContainerGroupMaint_Result _);
    }

    public ResultStatus New(ContainerGroupMaint containerGroupMaint)
    {
      return this.New(containerGroupMaint, (ContainerGroupMaint_Parameters) null, (ContainerGroupMaint_Request) null, out ContainerGroupMaint_Result _);
    }

    public ResultStatus New(
      ContainerGroupMaint containerGroupMaint,
      ContainerGroupMaint_Request request,
      out ContainerGroupMaint_Result result)
    {
      return this.New(containerGroupMaint, (ContainerGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ContainerGroupMaint containerGroupMaint,
      ContainerGroupMaint_Parameters parameters,
      ContainerGroupMaint_Request request,
      out ContainerGroupMaint_Result result)
    {
      result = (ContainerGroupMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) containerGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerGroupMaintService) this._Channel).NewCopy(this._UserProfile, containerGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ContainerGroupMaintMethod(containerGroupMaint, ContainerGroupMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) containerGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ContainerGroupMaint) null, (ContainerGroupMaint_Parameters) null, (ContainerGroupMaint_Request) null, out ContainerGroupMaint_Result _);
    }

    public ResultStatus NewCopy(ContainerGroupMaint containerGroupMaint)
    {
      return this.NewCopy(containerGroupMaint, (ContainerGroupMaint_Parameters) null, (ContainerGroupMaint_Request) null, out ContainerGroupMaint_Result _);
    }

    public ResultStatus NewCopy(
      ContainerGroupMaint containerGroupMaint,
      ContainerGroupMaint_Request request,
      out ContainerGroupMaint_Result result)
    {
      return this.NewCopy(containerGroupMaint, (ContainerGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ContainerGroupMaint containerGroupMaint,
      ContainerGroupMaint_Parameters parameters,
      ContainerGroupMaint_Request request,
      out ContainerGroupMaint_Result result)
    {
      result = (ContainerGroupMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) containerGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerGroupMaintService) this._Channel).SaveAs(this._UserProfile, containerGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ContainerGroupMaintMethod(containerGroupMaint, ContainerGroupMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) containerGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ContainerGroupMaint) null, (ContainerGroupMaint_Parameters) null, (ContainerGroupMaint_Request) null, out ContainerGroupMaint_Result _);
    }

    public ResultStatus SaveAs(ContainerGroupMaint containerGroupMaint)
    {
      return this.SaveAs(containerGroupMaint, (ContainerGroupMaint_Parameters) null, (ContainerGroupMaint_Request) null, out ContainerGroupMaint_Result _);
    }

    public ResultStatus SaveAs(
      ContainerGroupMaint containerGroupMaint,
      ContainerGroupMaint_Request request,
      out ContainerGroupMaint_Result result)
    {
      return this.SaveAs(containerGroupMaint, (ContainerGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ContainerGroupMaint containerGroupMaint,
      ContainerGroupMaint_Parameters parameters,
      ContainerGroupMaint_Request request,
      out ContainerGroupMaint_Result result)
    {
      result = (ContainerGroupMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) containerGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerGroupMaintService) this._Channel).UnFreeze(this._UserProfile, containerGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ContainerGroupMaintMethod(containerGroupMaint, ContainerGroupMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) containerGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ContainerGroupMaint) null, (ContainerGroupMaint_Parameters) null, (ContainerGroupMaint_Request) null, out ContainerGroupMaint_Result _);
    }

    public ResultStatus UnFreeze(ContainerGroupMaint containerGroupMaint)
    {
      return this.UnFreeze(containerGroupMaint, (ContainerGroupMaint_Parameters) null, (ContainerGroupMaint_Request) null, out ContainerGroupMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ContainerGroupMaint containerGroupMaint,
      ContainerGroupMaint_Request request,
      out ContainerGroupMaint_Result result)
    {
      return this.UnFreeze(containerGroupMaint, (ContainerGroupMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject containerGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerGroupMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ContainerGroupMaint) containerGroupMaint, (ContainerGroupMaint_Parameters) parameters, (ContainerGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject containerGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerGroupMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ContainerGroupMaint) containerGroupMaint, (ContainerGroupMaint_Parameters) parameters, (ContainerGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject containerGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerGroupMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ContainerGroupMaint) containerGroupMaint, (ContainerGroupMaint_LoadESigDetails_Parameters) parameters, (ContainerGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject containerGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerGroupMaint_Result result1;
        ResultStatus resultStatus = this.New((ContainerGroupMaint) containerGroupMaint, (ContainerGroupMaint_Parameters) parameters, (ContainerGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject containerGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerGroupMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ContainerGroupMaint) containerGroupMaint, (ContainerGroupMaint_Parameters) parameters, (ContainerGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject containerGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerGroupMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ContainerGroupMaint) containerGroupMaint, (ContainerGroupMaint_Parameters) parameters, (ContainerGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject containerGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerGroupMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ContainerGroupMaint) containerGroupMaint, (ContainerGroupMaint_Parameters) parameters, (ContainerGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject containerGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerGroupMaint_Result result1;
        ResultStatus resultStatus = this.Load((ContainerGroupMaint) containerGroupMaint, (ContainerGroupMaint_Parameters) parameters, (ContainerGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject containerGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerGroupMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ContainerGroupMaint) containerGroupMaint, (ContainerGroupMaint_Parameters) parameters, (ContainerGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ContainerGroupMaint_Request request,
      out ContainerGroupMaint_Result result)
    {
      result = (ContainerGroupMaint_Result) null;
      try
      {
        ContainerGroupMaintMethod[] methods = new ContainerGroupMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IContainerGroupMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnCommitTransaction(
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerGroupMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ContainerGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ContainerGroupMaint cdo,
      ContainerGroupMaint_Request request,
      out ContainerGroupMaint_Result result)
    {
      result = (ContainerGroupMaint_Result) null;
      try
      {
        return ((IContainerGroupMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetEnvironment(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerGroupMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ContainerGroupMaint) cdo, (ContainerGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ContainerGroupMaint_Request request,
      out ContainerGroupMaint_Result result)
    {
      return this.GetEnvironment((ContainerGroupMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ContainerGroupMaint cdo,
      ContainerGroupMaint_Request request,
      out ContainerGroupMaint_Result result)
    {
      result = (ContainerGroupMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerGroupMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ContainerGroupMaintMethod(cdo, ContainerGroupMaintMethods.ExecuteTransaction, (ContainerGroupMaint_Parameters) null));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ExecuteTransaction), res, (DCObject) cdo, (Parameters) null, (Request) request, (Result) result);
      return res;
    }

    protected override ResultStatus OnExecuteTransaction(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerGroupMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ContainerGroupMaint) cdo, (ContainerGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ContainerGroupMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ContainerGroupMaint_Request) null, out ContainerGroupMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ContainerGroupMaint_Request request,
      out ContainerGroupMaint_Result result)
    {
      return this.ExecuteTransaction((ContainerGroupMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ContainerGroupMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ContainerGroupMaintMethod(cdo, ContainerGroupMaintMethods.AddDataTransaction, (ContainerGroupMaint_Parameters) null));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
      {
        Result result;
        this.OnAfterCall(nameof (AddDataTransaction), res, (DCObject) cdo, (Parameters) null, (Request) null, result);
      }
      return res;
    }

    protected override ResultStatus OnAddDataTransaction(DCObject cdo)
    {
      try
      {
        return this.AddDataTransaction((ContainerGroupMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
