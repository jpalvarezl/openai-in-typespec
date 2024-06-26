import "./models.tsp";
import "./operations.tsp";

using TypeSpec.OpenAPI;

namespace OpenAI;

@@extension(OpenAI.FineTuning.listFineTuningJobCheckpoints,
  "x-oaiMeta",
  """
    name: List fine-tuning checkpoints
    group: fine-tuning
    returns: A list of fine-tuning [checkpoint objects](/docs/api-reference/fine-tuning/checkpoint-object) for a fine-tuning job.
    examples:
        request:
        curl: |
            curl https://api.openai.com/v1/fine_tuning/jobs/ftjob-abc123/checkpoints \\
            -H "Authorization: Bearer $OPENAI_API_KEY"
        response: |
        {
            "object": "list"
            "data": [
            {
                "object": "fine_tuning.job.checkpoint",
                "id": "ftckpt_zc4Q7MP6XxulcVzj4MZdwsAB",
                "created_at": 1519129973,
                "fine_tuned_model_checkpoint": "ft:gpt-3.5-turbo-0125:my-org:custom-suffix:96olL566:ckpt-step-2000",
                "metrics": {
                "full_valid_loss": 0.134,
                "full_valid_mean_token_accuracy": 0.874
                },
                "fine_tuning_job_id": "ftjob-abc123",
                "step_number": 2000,
            },
            {
                "object": "fine_tuning.job.checkpoint",
                "id": "ftckpt_enQCFmOTGj3syEpYVhBRLTSy",
                "created_at": 1519129833,
                "fine_tuned_model_checkpoint": "ft:gpt-3.5-turbo-0125:my-org:custom-suffix:7q8mpxmy:ckpt-step-1000",
                "metrics": {
                "full_valid_loss": 0.167,
                "full_valid_mean_token_accuracy": 0.781
                },
                "fine_tuning_job_id": "ftjob-abc123",
                "step_number": 1000,
            },
            ],
            "first_id": "ftckpt_zc4Q7MP6XxulcVzj4MZdwsAB",
            "last_id": "ftckpt_enQCFmOTGj3syEpYVhBRLTSy",
            "has_more": true
        }
   """
);
