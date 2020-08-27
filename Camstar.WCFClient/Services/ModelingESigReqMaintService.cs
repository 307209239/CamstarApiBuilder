// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ModelingESigReqMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ModelingESigReqMaintService : NamedDataObjectMaintBase
  {
    public ModelingESigReqMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IModelingESigReqMaintService), userProfile);
    }

    public ResultStatus Delete(
      ModelingESigReqMaint modelingESigReqMaint,
      ModelingESigReqMaint_Parameters parameters,
      ModelingESigReqMaint_Request request,
      out ModelingESigReqMaint_Result result)
    {
      result = (ModelingESigReqMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) modelingESigReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IModelingESigReqMaintService) this._Channel).Delete(this._UserProfile, modelingESigReqMaint, parameters, request, out result) : this.AddMethod((Method) new ModelingESigReqMaintMethod(modelingESigReqMaint, ModelingESigReqMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) modelingESigReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ModelingESigReqMaint) null, (ModelingESigReqMaint_Parameters) null, (ModelingESigReqMaint_Request) null, out ModelingESigReqMaint_Result _);
    }

    public ResultStatus Delete(ModelingESigReqMaint modelingESigReqMaint)
    {
      return this.Delete(modelingESigReqMaint, (ModelingESigReqMaint_Parameters) null, (ModelingESigReqMaint_Request) null, out ModelingESigReqMaint_Result _);
    }

    public ResultStatus Delete(
      ModelingESigReqMaint modelingESigReqMaint,
      ModelingESigReqMaint_Request request,
      out ModelingESigReqMaint_Result result)
    {
      return this.Delete(modelingESigReqMaint, (ModelingESigReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ModelingESigReqMaint modelingESigReqMaint,
      ModelingESigReqMaint_Parameters parameters,
      ModelingESigReqMaint_Request request,
      out ModelingESigReqMaint_Result result)
    {
      result = (ModelingESigReqMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) modelingESigReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IModelingESigReqMaintService) this._Channel).Freeze(this._UserProfile, modelingESigReqMaint, parameters, request, out result) : this.AddMethod((Method) new ModelingESigReqMaintMethod(modelingESigReqMaint, ModelingESigReqMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) modelingESigReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ModelingESigReqMaint) null, (ModelingESigReqMaint_Parameters) null, (ModelingESigReqMaint_Request) null, out ModelingESigReqMaint_Result _);
    }

    public ResultStatus Freeze(ModelingESigReqMaint modelingESigReqMaint)
    {
      return this.Freeze(modelingESigReqMaint, (ModelingESigReqMaint_Parameters) null, (ModelingESigReqMaint_Request) null, out ModelingESigReqMaint_Result _);
    }

    public ResultStatus Freeze(
      ModelingESigReqMaint modelingESigReqMaint,
      ModelingESigReqMaint_Request request,
      out ModelingESigReqMaint_Result result)
    {
      return this.Freeze(modelingESigReqMaint, (ModelingESigReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetResolvedRequirements(
      ModelingESigReqMaint modelingESigReqMaint,
      ModelingESigReqMaint_Parameters parameters,
      ModelingESigReqMaint_Request request,
      out ModelingESigReqMaint_Result result)
    {
      result = (ModelingESigReqMaint_Result) null;
      this.OnBeforeCall(nameof (GetResolvedRequirements), (DCObject) modelingESigReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IModelingESigReqMaintService) this._Channel).GetResolvedRequirements(this._UserProfile, modelingESigReqMaint, parameters, request, out result) : this.AddMethod((Method) new ModelingESigReqMaintMethod(modelingESigReqMaint, ModelingESigReqMaintMethods.GetResolvedRequirements, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetResolvedRequirements), res, (DCObject) modelingESigReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetResolvedRequirements()
    {
      return this.GetResolvedRequirements((ModelingESigReqMaint) null, (ModelingESigReqMaint_Parameters) null, (ModelingESigReqMaint_Request) null, out ModelingESigReqMaint_Result _);
    }

    public ResultStatus GetResolvedRequirements(
      ModelingESigReqMaint modelingESigReqMaint)
    {
      return this.GetResolvedRequirements(modelingESigReqMaint, (ModelingESigReqMaint_Parameters) null, (ModelingESigReqMaint_Request) null, out ModelingESigReqMaint_Result _);
    }

    public ResultStatus GetResolvedRequirements(
      ModelingESigReqMaint modelingESigReqMaint,
      ModelingESigReqMaint_Request request,
      out ModelingESigReqMaint_Result result)
    {
      return this.GetResolvedRequirements(modelingESigReqMaint, (ModelingESigReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ModelingESigReqMaint modelingESigReqMaint,
      ModelingESigReqMaint_Parameters parameters,
      ModelingESigReqMaint_Request request,
      out ModelingESigReqMaint_Result result)
    {
      result = (ModelingESigReqMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) modelingESigReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IModelingESigReqMaintService) this._Channel).GetWIPMsgs(this._UserProfile, modelingESigReqMaint, parameters, request, out result) : this.AddMethod((Method) new ModelingESigReqMaintMethod(modelingESigReqMaint, ModelingESigReqMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) modelingESigReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ModelingESigReqMaint) null, (ModelingESigReqMaint_Parameters) null, (ModelingESigReqMaint_Request) null, out ModelingESigReqMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(ModelingESigReqMaint modelingESigReqMaint)
    {
      return this.GetWIPMsgs(modelingESigReqMaint, (ModelingESigReqMaint_Parameters) null, (ModelingESigReqMaint_Request) null, out ModelingESigReqMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ModelingESigReqMaint modelingESigReqMaint,
      ModelingESigReqMaint_Request request,
      out ModelingESigReqMaint_Result result)
    {
      return this.GetWIPMsgs(modelingESigReqMaint, (ModelingESigReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ModelingESigReqMaint modelingESigReqMaint,
      ModelingESigReqMaint_Parameters parameters,
      ModelingESigReqMaint_Request request,
      out ModelingESigReqMaint_Result result)
    {
      result = (ModelingESigReqMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) modelingESigReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IModelingESigReqMaintService) this._Channel).Load(this._UserProfile, modelingESigReqMaint, parameters, request, out result) : this.AddMethod((Method) new ModelingESigReqMaintMethod(modelingESigReqMaint, ModelingESigReqMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) modelingESigReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ModelingESigReqMaint) null, (ModelingESigReqMaint_Parameters) null, (ModelingESigReqMaint_Request) null, out ModelingESigReqMaint_Result _);
    }

    public ResultStatus Load(ModelingESigReqMaint modelingESigReqMaint)
    {
      return this.Load(modelingESigReqMaint, (ModelingESigReqMaint_Parameters) null, (ModelingESigReqMaint_Request) null, out ModelingESigReqMaint_Result _);
    }

    public ResultStatus Load(
      ModelingESigReqMaint modelingESigReqMaint,
      ModelingESigReqMaint_Request request,
      out ModelingESigReqMaint_Result result)
    {
      return this.Load(modelingESigReqMaint, (ModelingESigReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ModelingESigReqMaint modelingESigReqMaint,
      ModelingESigReqMaint_LoadESigDetails_Parameters parameters,
      ModelingESigReqMaint_Request request,
      out ModelingESigReqMaint_Result result)
    {
      result = (ModelingESigReqMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) modelingESigReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IModelingESigReqMaintService) this._Channel).LoadESigDetails(this._UserProfile, modelingESigReqMaint, parameters, request, out result) : this.AddMethod((Method) new ModelingESigReqMaintMethod(modelingESigReqMaint, ModelingESigReqMaintMethods.LoadESigDetails, (ModelingESigReqMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) modelingESigReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ModelingESigReqMaint) null, (ModelingESigReqMaint_LoadESigDetails_Parameters) null, (ModelingESigReqMaint_Request) null, out ModelingESigReqMaint_Result _);
    }

    public ResultStatus LoadESigDetails(ModelingESigReqMaint modelingESigReqMaint)
    {
      return this.LoadESigDetails(modelingESigReqMaint, (ModelingESigReqMaint_LoadESigDetails_Parameters) null, (ModelingESigReqMaint_Request) null, out ModelingESigReqMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ModelingESigReqMaint modelingESigReqMaint,
      ModelingESigReqMaint_Request request,
      out ModelingESigReqMaint_Result result)
    {
      return this.LoadESigDetails(modelingESigReqMaint, (ModelingESigReqMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus LoadValues(
      ModelingESigReqMaint modelingESigReqMaint,
      ModelingESigReqMaint_Parameters parameters,
      ModelingESigReqMaint_Request request,
      out ModelingESigReqMaint_Result result)
    {
      result = (ModelingESigReqMaint_Result) null;
      this.OnBeforeCall(nameof (LoadValues), (DCObject) modelingESigReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IModelingESigReqMaintService) this._Channel).LoadValues(this._UserProfile, modelingESigReqMaint, parameters, request, out result) : this.AddMethod((Method) new ModelingESigReqMaintMethod(modelingESigReqMaint, ModelingESigReqMaintMethods.LoadValues, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadValues), res, (DCObject) modelingESigReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadValues()
    {
      return this.LoadValues((ModelingESigReqMaint) null, (ModelingESigReqMaint_Parameters) null, (ModelingESigReqMaint_Request) null, out ModelingESigReqMaint_Result _);
    }

    public ResultStatus LoadValues(ModelingESigReqMaint modelingESigReqMaint)
    {
      return this.LoadValues(modelingESigReqMaint, (ModelingESigReqMaint_Parameters) null, (ModelingESigReqMaint_Request) null, out ModelingESigReqMaint_Result _);
    }

    public ResultStatus LoadValues(
      ModelingESigReqMaint modelingESigReqMaint,
      ModelingESigReqMaint_Request request,
      out ModelingESigReqMaint_Result result)
    {
      return this.LoadValues(modelingESigReqMaint, (ModelingESigReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ModelingESigReqMaint modelingESigReqMaint,
      ModelingESigReqMaint_Parameters parameters,
      ModelingESigReqMaint_Request request,
      out ModelingESigReqMaint_Result result)
    {
      result = (ModelingESigReqMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) modelingESigReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IModelingESigReqMaintService) this._Channel).New(this._UserProfile, modelingESigReqMaint, parameters, request, out result) : this.AddMethod((Method) new ModelingESigReqMaintMethod(modelingESigReqMaint, ModelingESigReqMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) modelingESigReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ModelingESigReqMaint) null, (ModelingESigReqMaint_Parameters) null, (ModelingESigReqMaint_Request) null, out ModelingESigReqMaint_Result _);
    }

    public ResultStatus New(ModelingESigReqMaint modelingESigReqMaint)
    {
      return this.New(modelingESigReqMaint, (ModelingESigReqMaint_Parameters) null, (ModelingESigReqMaint_Request) null, out ModelingESigReqMaint_Result _);
    }

    public ResultStatus New(
      ModelingESigReqMaint modelingESigReqMaint,
      ModelingESigReqMaint_Request request,
      out ModelingESigReqMaint_Result result)
    {
      return this.New(modelingESigReqMaint, (ModelingESigReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ModelingESigReqMaint modelingESigReqMaint,
      ModelingESigReqMaint_Parameters parameters,
      ModelingESigReqMaint_Request request,
      out ModelingESigReqMaint_Result result)
    {
      result = (ModelingESigReqMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) modelingESigReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IModelingESigReqMaintService) this._Channel).NewCopy(this._UserProfile, modelingESigReqMaint, parameters, request, out result) : this.AddMethod((Method) new ModelingESigReqMaintMethod(modelingESigReqMaint, ModelingESigReqMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) modelingESigReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ModelingESigReqMaint) null, (ModelingESigReqMaint_Parameters) null, (ModelingESigReqMaint_Request) null, out ModelingESigReqMaint_Result _);
    }

    public ResultStatus NewCopy(ModelingESigReqMaint modelingESigReqMaint)
    {
      return this.NewCopy(modelingESigReqMaint, (ModelingESigReqMaint_Parameters) null, (ModelingESigReqMaint_Request) null, out ModelingESigReqMaint_Result _);
    }

    public ResultStatus NewCopy(
      ModelingESigReqMaint modelingESigReqMaint,
      ModelingESigReqMaint_Request request,
      out ModelingESigReqMaint_Result result)
    {
      return this.NewCopy(modelingESigReqMaint, (ModelingESigReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus Process(
      ModelingESigReqMaint modelingESigReqMaint,
      ModelingESigReqMaint_Parameters parameters,
      ModelingESigReqMaint_Request request,
      out ModelingESigReqMaint_Result result)
    {
      result = (ModelingESigReqMaint_Result) null;
      this.OnBeforeCall(nameof (Process), (DCObject) modelingESigReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IModelingESigReqMaintService) this._Channel).Process(this._UserProfile, modelingESigReqMaint, parameters, request, out result) : this.AddMethod((Method) new ModelingESigReqMaintMethod(modelingESigReqMaint, ModelingESigReqMaintMethods.Process, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Process), res, (DCObject) modelingESigReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Process()
    {
      return this.Process((ModelingESigReqMaint) null, (ModelingESigReqMaint_Parameters) null, (ModelingESigReqMaint_Request) null, out ModelingESigReqMaint_Result _);
    }

    public ResultStatus Process(ModelingESigReqMaint modelingESigReqMaint)
    {
      return this.Process(modelingESigReqMaint, (ModelingESigReqMaint_Parameters) null, (ModelingESigReqMaint_Request) null, out ModelingESigReqMaint_Result _);
    }

    public ResultStatus Process(
      ModelingESigReqMaint modelingESigReqMaint,
      ModelingESigReqMaint_Request request,
      out ModelingESigReqMaint_Result result)
    {
      return this.Process(modelingESigReqMaint, (ModelingESigReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ModelingESigReqMaint modelingESigReqMaint,
      ModelingESigReqMaint_Parameters parameters,
      ModelingESigReqMaint_Request request,
      out ModelingESigReqMaint_Result result)
    {
      result = (ModelingESigReqMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) modelingESigReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IModelingESigReqMaintService) this._Channel).SaveAs(this._UserProfile, modelingESigReqMaint, parameters, request, out result) : this.AddMethod((Method) new ModelingESigReqMaintMethod(modelingESigReqMaint, ModelingESigReqMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) modelingESigReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ModelingESigReqMaint) null, (ModelingESigReqMaint_Parameters) null, (ModelingESigReqMaint_Request) null, out ModelingESigReqMaint_Result _);
    }

    public ResultStatus SaveAs(ModelingESigReqMaint modelingESigReqMaint)
    {
      return this.SaveAs(modelingESigReqMaint, (ModelingESigReqMaint_Parameters) null, (ModelingESigReqMaint_Request) null, out ModelingESigReqMaint_Result _);
    }

    public ResultStatus SaveAs(
      ModelingESigReqMaint modelingESigReqMaint,
      ModelingESigReqMaint_Request request,
      out ModelingESigReqMaint_Result result)
    {
      return this.SaveAs(modelingESigReqMaint, (ModelingESigReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ModelingESigReqMaint modelingESigReqMaint,
      ModelingESigReqMaint_Parameters parameters,
      ModelingESigReqMaint_Request request,
      out ModelingESigReqMaint_Result result)
    {
      result = (ModelingESigReqMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) modelingESigReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IModelingESigReqMaintService) this._Channel).UnFreeze(this._UserProfile, modelingESigReqMaint, parameters, request, out result) : this.AddMethod((Method) new ModelingESigReqMaintMethod(modelingESigReqMaint, ModelingESigReqMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) modelingESigReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ModelingESigReqMaint) null, (ModelingESigReqMaint_Parameters) null, (ModelingESigReqMaint_Request) null, out ModelingESigReqMaint_Result _);
    }

    public ResultStatus UnFreeze(ModelingESigReqMaint modelingESigReqMaint)
    {
      return this.UnFreeze(modelingESigReqMaint, (ModelingESigReqMaint_Parameters) null, (ModelingESigReqMaint_Request) null, out ModelingESigReqMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ModelingESigReqMaint modelingESigReqMaint,
      ModelingESigReqMaint_Request request,
      out ModelingESigReqMaint_Result result)
    {
      return this.UnFreeze(modelingESigReqMaint, (ModelingESigReqMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject modelingESigReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ModelingESigReqMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ModelingESigReqMaint) modelingESigReqMaint, (ModelingESigReqMaint_Parameters) parameters, (ModelingESigReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject modelingESigReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ModelingESigReqMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ModelingESigReqMaint) modelingESigReqMaint, (ModelingESigReqMaint_Parameters) parameters, (ModelingESigReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject modelingESigReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ModelingESigReqMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ModelingESigReqMaint) modelingESigReqMaint, (ModelingESigReqMaint_LoadESigDetails_Parameters) parameters, (ModelingESigReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject modelingESigReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ModelingESigReqMaint_Result result1;
        ResultStatus resultStatus = this.New((ModelingESigReqMaint) modelingESigReqMaint, (ModelingESigReqMaint_Parameters) parameters, (ModelingESigReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject modelingESigReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ModelingESigReqMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ModelingESigReqMaint) modelingESigReqMaint, (ModelingESigReqMaint_Parameters) parameters, (ModelingESigReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject modelingESigReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ModelingESigReqMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ModelingESigReqMaint) modelingESigReqMaint, (ModelingESigReqMaint_Parameters) parameters, (ModelingESigReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject modelingESigReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ModelingESigReqMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ModelingESigReqMaint) modelingESigReqMaint, (ModelingESigReqMaint_Parameters) parameters, (ModelingESigReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject modelingESigReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ModelingESigReqMaint_Result result1;
        ResultStatus resultStatus = this.Load((ModelingESigReqMaint) modelingESigReqMaint, (ModelingESigReqMaint_Parameters) parameters, (ModelingESigReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject modelingESigReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ModelingESigReqMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ModelingESigReqMaint) modelingESigReqMaint, (ModelingESigReqMaint_Parameters) parameters, (ModelingESigReqMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ModelingESigReqMaint_Request request,
      out ModelingESigReqMaint_Result result)
    {
      result = (ModelingESigReqMaint_Result) null;
      try
      {
        ModelingESigReqMaintMethod[] methods = new ModelingESigReqMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IModelingESigReqMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ModelingESigReqMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ModelingESigReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ModelingESigReqMaint cdo,
      ModelingESigReqMaint_Request request,
      out ModelingESigReqMaint_Result result)
    {
      result = (ModelingESigReqMaint_Result) null;
      try
      {
        return ((IModelingESigReqMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ModelingESigReqMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ModelingESigReqMaint) cdo, (ModelingESigReqMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ModelingESigReqMaint_Request request,
      out ModelingESigReqMaint_Result result)
    {
      return this.GetEnvironment((ModelingESigReqMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ModelingESigReqMaint cdo,
      ModelingESigReqMaint_Request request,
      out ModelingESigReqMaint_Result result)
    {
      result = (ModelingESigReqMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IModelingESigReqMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ModelingESigReqMaintMethod(cdo, ModelingESigReqMaintMethods.ExecuteTransaction, (ModelingESigReqMaint_Parameters) null));
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
        ModelingESigReqMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ModelingESigReqMaint) cdo, (ModelingESigReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ModelingESigReqMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ModelingESigReqMaint_Request) null, out ModelingESigReqMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ModelingESigReqMaint_Request request,
      out ModelingESigReqMaint_Result result)
    {
      return this.ExecuteTransaction((ModelingESigReqMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ModelingESigReqMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ModelingESigReqMaintMethod(cdo, ModelingESigReqMaintMethods.AddDataTransaction, (ModelingESigReqMaint_Parameters) null));
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
        return this.AddDataTransaction((ModelingESigReqMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
