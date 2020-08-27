// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ResStatusCodeGroupMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ResStatusCodeGroupMaintService : UserCodeGroupMaintBase
  {
    public ResStatusCodeGroupMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IResStatusCodeGroupMaintService), userProfile);
    }

    public ResultStatus Delete(
      ResStatusCodeGroupMaint resStatusCodeGroupMaint,
      ResStatusCodeGroupMaint_Parameters parameters,
      ResStatusCodeGroupMaint_Request request,
      out ResStatusCodeGroupMaint_Result result)
    {
      result = (ResStatusCodeGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) resStatusCodeGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResStatusCodeGroupMaintService) this._Channel).Delete(this._UserProfile, resStatusCodeGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ResStatusCodeGroupMaintMethod(resStatusCodeGroupMaint, ResStatusCodeGroupMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) resStatusCodeGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ResStatusCodeGroupMaint) null, (ResStatusCodeGroupMaint_Parameters) null, (ResStatusCodeGroupMaint_Request) null, out ResStatusCodeGroupMaint_Result _);
    }

    public ResultStatus Delete(ResStatusCodeGroupMaint resStatusCodeGroupMaint)
    {
      return this.Delete(resStatusCodeGroupMaint, (ResStatusCodeGroupMaint_Parameters) null, (ResStatusCodeGroupMaint_Request) null, out ResStatusCodeGroupMaint_Result _);
    }

    public ResultStatus Delete(
      ResStatusCodeGroupMaint resStatusCodeGroupMaint,
      ResStatusCodeGroupMaint_Request request,
      out ResStatusCodeGroupMaint_Result result)
    {
      return this.Delete(resStatusCodeGroupMaint, (ResStatusCodeGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ResStatusCodeGroupMaint resStatusCodeGroupMaint,
      ResStatusCodeGroupMaint_Parameters parameters,
      ResStatusCodeGroupMaint_Request request,
      out ResStatusCodeGroupMaint_Result result)
    {
      result = (ResStatusCodeGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) resStatusCodeGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResStatusCodeGroupMaintService) this._Channel).Freeze(this._UserProfile, resStatusCodeGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ResStatusCodeGroupMaintMethod(resStatusCodeGroupMaint, ResStatusCodeGroupMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) resStatusCodeGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ResStatusCodeGroupMaint) null, (ResStatusCodeGroupMaint_Parameters) null, (ResStatusCodeGroupMaint_Request) null, out ResStatusCodeGroupMaint_Result _);
    }

    public ResultStatus Freeze(ResStatusCodeGroupMaint resStatusCodeGroupMaint)
    {
      return this.Freeze(resStatusCodeGroupMaint, (ResStatusCodeGroupMaint_Parameters) null, (ResStatusCodeGroupMaint_Request) null, out ResStatusCodeGroupMaint_Result _);
    }

    public ResultStatus Freeze(
      ResStatusCodeGroupMaint resStatusCodeGroupMaint,
      ResStatusCodeGroupMaint_Request request,
      out ResStatusCodeGroupMaint_Result result)
    {
      return this.Freeze(resStatusCodeGroupMaint, (ResStatusCodeGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ResStatusCodeGroupMaint resStatusCodeGroupMaint,
      ResStatusCodeGroupMaint_Parameters parameters,
      ResStatusCodeGroupMaint_Request request,
      out ResStatusCodeGroupMaint_Result result)
    {
      result = (ResStatusCodeGroupMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) resStatusCodeGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResStatusCodeGroupMaintService) this._Channel).GetWIPMsgs(this._UserProfile, resStatusCodeGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ResStatusCodeGroupMaintMethod(resStatusCodeGroupMaint, ResStatusCodeGroupMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) resStatusCodeGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ResStatusCodeGroupMaint) null, (ResStatusCodeGroupMaint_Parameters) null, (ResStatusCodeGroupMaint_Request) null, out ResStatusCodeGroupMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(ResStatusCodeGroupMaint resStatusCodeGroupMaint)
    {
      return this.GetWIPMsgs(resStatusCodeGroupMaint, (ResStatusCodeGroupMaint_Parameters) null, (ResStatusCodeGroupMaint_Request) null, out ResStatusCodeGroupMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ResStatusCodeGroupMaint resStatusCodeGroupMaint,
      ResStatusCodeGroupMaint_Request request,
      out ResStatusCodeGroupMaint_Result result)
    {
      return this.GetWIPMsgs(resStatusCodeGroupMaint, (ResStatusCodeGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ResStatusCodeGroupMaint resStatusCodeGroupMaint,
      ResStatusCodeGroupMaint_Parameters parameters,
      ResStatusCodeGroupMaint_Request request,
      out ResStatusCodeGroupMaint_Result result)
    {
      result = (ResStatusCodeGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) resStatusCodeGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResStatusCodeGroupMaintService) this._Channel).Load(this._UserProfile, resStatusCodeGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ResStatusCodeGroupMaintMethod(resStatusCodeGroupMaint, ResStatusCodeGroupMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) resStatusCodeGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ResStatusCodeGroupMaint) null, (ResStatusCodeGroupMaint_Parameters) null, (ResStatusCodeGroupMaint_Request) null, out ResStatusCodeGroupMaint_Result _);
    }

    public ResultStatus Load(ResStatusCodeGroupMaint resStatusCodeGroupMaint)
    {
      return this.Load(resStatusCodeGroupMaint, (ResStatusCodeGroupMaint_Parameters) null, (ResStatusCodeGroupMaint_Request) null, out ResStatusCodeGroupMaint_Result _);
    }

    public ResultStatus Load(
      ResStatusCodeGroupMaint resStatusCodeGroupMaint,
      ResStatusCodeGroupMaint_Request request,
      out ResStatusCodeGroupMaint_Result result)
    {
      return this.Load(resStatusCodeGroupMaint, (ResStatusCodeGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ResStatusCodeGroupMaint resStatusCodeGroupMaint,
      ResStatusCodeGroupMaint_LoadESigDetails_Parameters parameters,
      ResStatusCodeGroupMaint_Request request,
      out ResStatusCodeGroupMaint_Result result)
    {
      result = (ResStatusCodeGroupMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) resStatusCodeGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResStatusCodeGroupMaintService) this._Channel).LoadESigDetails(this._UserProfile, resStatusCodeGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ResStatusCodeGroupMaintMethod(resStatusCodeGroupMaint, ResStatusCodeGroupMaintMethods.LoadESigDetails, (ResStatusCodeGroupMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) resStatusCodeGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ResStatusCodeGroupMaint) null, (ResStatusCodeGroupMaint_LoadESigDetails_Parameters) null, (ResStatusCodeGroupMaint_Request) null, out ResStatusCodeGroupMaint_Result _);
    }

    public ResultStatus LoadESigDetails(ResStatusCodeGroupMaint resStatusCodeGroupMaint)
    {
      return this.LoadESigDetails(resStatusCodeGroupMaint, (ResStatusCodeGroupMaint_LoadESigDetails_Parameters) null, (ResStatusCodeGroupMaint_Request) null, out ResStatusCodeGroupMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ResStatusCodeGroupMaint resStatusCodeGroupMaint,
      ResStatusCodeGroupMaint_Request request,
      out ResStatusCodeGroupMaint_Result result)
    {
      return this.LoadESigDetails(resStatusCodeGroupMaint, (ResStatusCodeGroupMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ResStatusCodeGroupMaint resStatusCodeGroupMaint,
      ResStatusCodeGroupMaint_Parameters parameters,
      ResStatusCodeGroupMaint_Request request,
      out ResStatusCodeGroupMaint_Result result)
    {
      result = (ResStatusCodeGroupMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) resStatusCodeGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResStatusCodeGroupMaintService) this._Channel).New(this._UserProfile, resStatusCodeGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ResStatusCodeGroupMaintMethod(resStatusCodeGroupMaint, ResStatusCodeGroupMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) resStatusCodeGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ResStatusCodeGroupMaint) null, (ResStatusCodeGroupMaint_Parameters) null, (ResStatusCodeGroupMaint_Request) null, out ResStatusCodeGroupMaint_Result _);
    }

    public ResultStatus New(ResStatusCodeGroupMaint resStatusCodeGroupMaint)
    {
      return this.New(resStatusCodeGroupMaint, (ResStatusCodeGroupMaint_Parameters) null, (ResStatusCodeGroupMaint_Request) null, out ResStatusCodeGroupMaint_Result _);
    }

    public ResultStatus New(
      ResStatusCodeGroupMaint resStatusCodeGroupMaint,
      ResStatusCodeGroupMaint_Request request,
      out ResStatusCodeGroupMaint_Result result)
    {
      return this.New(resStatusCodeGroupMaint, (ResStatusCodeGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ResStatusCodeGroupMaint resStatusCodeGroupMaint,
      ResStatusCodeGroupMaint_Parameters parameters,
      ResStatusCodeGroupMaint_Request request,
      out ResStatusCodeGroupMaint_Result result)
    {
      result = (ResStatusCodeGroupMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) resStatusCodeGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResStatusCodeGroupMaintService) this._Channel).NewCopy(this._UserProfile, resStatusCodeGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ResStatusCodeGroupMaintMethod(resStatusCodeGroupMaint, ResStatusCodeGroupMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) resStatusCodeGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ResStatusCodeGroupMaint) null, (ResStatusCodeGroupMaint_Parameters) null, (ResStatusCodeGroupMaint_Request) null, out ResStatusCodeGroupMaint_Result _);
    }

    public ResultStatus NewCopy(ResStatusCodeGroupMaint resStatusCodeGroupMaint)
    {
      return this.NewCopy(resStatusCodeGroupMaint, (ResStatusCodeGroupMaint_Parameters) null, (ResStatusCodeGroupMaint_Request) null, out ResStatusCodeGroupMaint_Result _);
    }

    public ResultStatus NewCopy(
      ResStatusCodeGroupMaint resStatusCodeGroupMaint,
      ResStatusCodeGroupMaint_Request request,
      out ResStatusCodeGroupMaint_Result result)
    {
      return this.NewCopy(resStatusCodeGroupMaint, (ResStatusCodeGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ResStatusCodeGroupMaint resStatusCodeGroupMaint,
      ResStatusCodeGroupMaint_Parameters parameters,
      ResStatusCodeGroupMaint_Request request,
      out ResStatusCodeGroupMaint_Result result)
    {
      result = (ResStatusCodeGroupMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) resStatusCodeGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResStatusCodeGroupMaintService) this._Channel).SaveAs(this._UserProfile, resStatusCodeGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ResStatusCodeGroupMaintMethod(resStatusCodeGroupMaint, ResStatusCodeGroupMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) resStatusCodeGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ResStatusCodeGroupMaint) null, (ResStatusCodeGroupMaint_Parameters) null, (ResStatusCodeGroupMaint_Request) null, out ResStatusCodeGroupMaint_Result _);
    }

    public ResultStatus SaveAs(ResStatusCodeGroupMaint resStatusCodeGroupMaint)
    {
      return this.SaveAs(resStatusCodeGroupMaint, (ResStatusCodeGroupMaint_Parameters) null, (ResStatusCodeGroupMaint_Request) null, out ResStatusCodeGroupMaint_Result _);
    }

    public ResultStatus SaveAs(
      ResStatusCodeGroupMaint resStatusCodeGroupMaint,
      ResStatusCodeGroupMaint_Request request,
      out ResStatusCodeGroupMaint_Result result)
    {
      return this.SaveAs(resStatusCodeGroupMaint, (ResStatusCodeGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ResStatusCodeGroupMaint resStatusCodeGroupMaint,
      ResStatusCodeGroupMaint_Parameters parameters,
      ResStatusCodeGroupMaint_Request request,
      out ResStatusCodeGroupMaint_Result result)
    {
      result = (ResStatusCodeGroupMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) resStatusCodeGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResStatusCodeGroupMaintService) this._Channel).UnFreeze(this._UserProfile, resStatusCodeGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ResStatusCodeGroupMaintMethod(resStatusCodeGroupMaint, ResStatusCodeGroupMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) resStatusCodeGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ResStatusCodeGroupMaint) null, (ResStatusCodeGroupMaint_Parameters) null, (ResStatusCodeGroupMaint_Request) null, out ResStatusCodeGroupMaint_Result _);
    }

    public ResultStatus UnFreeze(ResStatusCodeGroupMaint resStatusCodeGroupMaint)
    {
      return this.UnFreeze(resStatusCodeGroupMaint, (ResStatusCodeGroupMaint_Parameters) null, (ResStatusCodeGroupMaint_Request) null, out ResStatusCodeGroupMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ResStatusCodeGroupMaint resStatusCodeGroupMaint,
      ResStatusCodeGroupMaint_Request request,
      out ResStatusCodeGroupMaint_Result result)
    {
      return this.UnFreeze(resStatusCodeGroupMaint, (ResStatusCodeGroupMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject resStatusCodeGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResStatusCodeGroupMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ResStatusCodeGroupMaint) resStatusCodeGroupMaint, (ResStatusCodeGroupMaint_Parameters) parameters, (ResStatusCodeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject resStatusCodeGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResStatusCodeGroupMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ResStatusCodeGroupMaint) resStatusCodeGroupMaint, (ResStatusCodeGroupMaint_Parameters) parameters, (ResStatusCodeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject resStatusCodeGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResStatusCodeGroupMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ResStatusCodeGroupMaint) resStatusCodeGroupMaint, (ResStatusCodeGroupMaint_LoadESigDetails_Parameters) parameters, (ResStatusCodeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject resStatusCodeGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResStatusCodeGroupMaint_Result result1;
        ResultStatus resultStatus = this.New((ResStatusCodeGroupMaint) resStatusCodeGroupMaint, (ResStatusCodeGroupMaint_Parameters) parameters, (ResStatusCodeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject resStatusCodeGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResStatusCodeGroupMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ResStatusCodeGroupMaint) resStatusCodeGroupMaint, (ResStatusCodeGroupMaint_Parameters) parameters, (ResStatusCodeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject resStatusCodeGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResStatusCodeGroupMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ResStatusCodeGroupMaint) resStatusCodeGroupMaint, (ResStatusCodeGroupMaint_Parameters) parameters, (ResStatusCodeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject resStatusCodeGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResStatusCodeGroupMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ResStatusCodeGroupMaint) resStatusCodeGroupMaint, (ResStatusCodeGroupMaint_Parameters) parameters, (ResStatusCodeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject resStatusCodeGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResStatusCodeGroupMaint_Result result1;
        ResultStatus resultStatus = this.Load((ResStatusCodeGroupMaint) resStatusCodeGroupMaint, (ResStatusCodeGroupMaint_Parameters) parameters, (ResStatusCodeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject resStatusCodeGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResStatusCodeGroupMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ResStatusCodeGroupMaint) resStatusCodeGroupMaint, (ResStatusCodeGroupMaint_Parameters) parameters, (ResStatusCodeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ResStatusCodeGroupMaint_Request request,
      out ResStatusCodeGroupMaint_Result result)
    {
      result = (ResStatusCodeGroupMaint_Result) null;
      try
      {
        ResStatusCodeGroupMaintMethod[] methods = new ResStatusCodeGroupMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IResStatusCodeGroupMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ResStatusCodeGroupMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ResStatusCodeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ResStatusCodeGroupMaint cdo,
      ResStatusCodeGroupMaint_Request request,
      out ResStatusCodeGroupMaint_Result result)
    {
      result = (ResStatusCodeGroupMaint_Result) null;
      try
      {
        return ((IResStatusCodeGroupMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ResStatusCodeGroupMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ResStatusCodeGroupMaint) cdo, (ResStatusCodeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ResStatusCodeGroupMaint_Request request,
      out ResStatusCodeGroupMaint_Result result)
    {
      return this.GetEnvironment((ResStatusCodeGroupMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ResStatusCodeGroupMaint cdo,
      ResStatusCodeGroupMaint_Request request,
      out ResStatusCodeGroupMaint_Result result)
    {
      result = (ResStatusCodeGroupMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResStatusCodeGroupMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ResStatusCodeGroupMaintMethod(cdo, ResStatusCodeGroupMaintMethods.ExecuteTransaction, (ResStatusCodeGroupMaint_Parameters) null));
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
        ResStatusCodeGroupMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ResStatusCodeGroupMaint) cdo, (ResStatusCodeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ResStatusCodeGroupMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ResStatusCodeGroupMaint_Request) null, out ResStatusCodeGroupMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ResStatusCodeGroupMaint_Request request,
      out ResStatusCodeGroupMaint_Result result)
    {
      return this.ExecuteTransaction((ResStatusCodeGroupMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ResStatusCodeGroupMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ResStatusCodeGroupMaintMethod(cdo, ResStatusCodeGroupMaintMethods.AddDataTransaction, (ResStatusCodeGroupMaint_Parameters) null));
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
        return this.AddDataTransaction((ResStatusCodeGroupMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
